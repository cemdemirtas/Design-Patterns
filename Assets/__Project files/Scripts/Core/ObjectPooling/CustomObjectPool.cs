
using System.Collections.Generic;
using UnityEngine;
using Nasser.io.DesignPatterns.SINGLETON;
using System.Collections;

namespace Nasser.io.DesignPatterns.Pool
{
    public class CustomObjectPool : SINGLETON<CustomObjectPool>
    {
        [SerializeField] GameObject objectToPool;
        [SerializeField] int amountToPool;

        private Queue<GameObject> pooledObjects = new Queue<GameObject>();

        GameObject tmp;

        void Awake()
        {
            base.RegisterSingletone();
        }

        void Start()
        {
            AddToPool(amountToPool);
        }

        public GameObject GetFromPool()
        {
            if (pooledObjects.Count == 0)
                AddToPool(1);

            var obj =  pooledObjects.Dequeue();
            obj.SetActive(true);
            obj.transform.position = Camera.main.ViewportToWorldPoint(new Vector3(Random.value, Random.value, 10));
            StartCoroutine(nameof(Destroy), obj);
            return obj;

        }

        private void AddToPool(int count)
        {
            for (int i = 0; i < count; i++)
            {
                if (i < count - 1)
                    tmp = Instantiate(objectToPool);
                else
                    tmp = Instantiate(objectToPool);
                tmp.SetActive(false);
                pooledObjects.Enqueue(tmp);

            }
        }

        public void ReturnToPool(GameObject returnObject)
        {
            returnObject.SetActive(false);
            pooledObjects.Enqueue(returnObject);
        }

        IEnumerator Destroy(GameObject _spike)
        {

            yield return new WaitForSeconds(5f);
            ReturnToPool(_spike);
        }
    }
}