
using UnityEngine;

namespace Nasser.io.DesignPatterns.SINGLETON
{
    //
    // SINGLETON is a single instance in the games Like the game manager

    public class SINGLETON<T> : MonoBehaviour where T : MonoBehaviour
    {
        public static T instance;
        public bool isDontDestroyOnload;
        private void Awake()
        {
            RegisterSingletone();
        }

        protected void RegisterSingletone()
        {
            if (instance == null)
            {
                instance = this as T;
                if (isDontDestroyOnload)
                    DontDestroyOnLoad(gameObject);
            }
            else
                Destroy(gameObject);

        }
    }
}
