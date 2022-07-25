using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nasser.io.DesignPatterns.SINGLETON
{
    public class PlayerSingleton : SINGLETON<PlayerSingleton>
    {
        int health;
        private void Awake()
        {
            base.RegisterSingletone();
            health = 100;
        }

        public void SetPlayerHealth(int addedAmount)
        {

            health += addedAmount;
        }

        public int GetPlayerHealth()
        {
            return health;
        }
    }
}
