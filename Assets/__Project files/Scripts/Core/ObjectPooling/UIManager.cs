
using UnityEngine;
using UnityEngine.UI;

namespace Nasser.io.DesignPatterns.Pool
{
    public class UIManager : MonoBehaviour
    {

        [SerializeField] Toggle isUnityPool;

        public void SpwanSpike()
        {
            if (isUnityPool.isOn == true)
                ObjectPoolingManager.instance.SpawnNewSpike();
            else
               CustomObjectPool.instance.GetFromPool();

        }
    }
}
