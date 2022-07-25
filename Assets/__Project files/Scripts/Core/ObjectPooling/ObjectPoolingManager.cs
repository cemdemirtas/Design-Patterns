using Nasser.io.DesignPatterns.SINGLETON;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

namespace Nasser.io.DesignPatterns.Pool
{
    public class ObjectPoolingManager : SINGLETON<ObjectPoolingManager>
    {
        [SerializeField] SpikeController spikeToSpwan;
        [SerializeField] int startAmount;
        private ObjectPool<SpikeController> spikePool;

        private void Awake()
        {
            base.RegisterSingletone();
        }

        private void Start()
        {
            spikePool = new ObjectPool<SpikeController>(() =>
            {
                return Instantiate(spikeToSpwan);
            }, spike =>
            {
                spike.gameObject.SetActive(true);
            }, spike =>
            {
                spike.gameObject.SetActive(false);
            }, spike =>
            {
                Destroy(spike.gameObject);
            }, false, startAmount, 100);
        }


        public void SpawnNewSpike()
        {
            var tempSpike = spikePool.Get();
            tempSpike.transform.position = Camera.main.ViewportToWorldPoint(new Vector3(Random.value, Random.value, 10));
            StartCoroutine(nameof(Destroy), tempSpike);
        }

        IEnumerator Destroy(SpikeController _spike)
        {

            yield return new WaitForSeconds(5f);
            spikePool.Release(_spike);
        }
    }
}
