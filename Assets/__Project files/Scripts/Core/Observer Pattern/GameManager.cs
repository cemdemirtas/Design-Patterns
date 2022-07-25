
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

namespace Nasser.io.DesignPatterns.Observer
{
    public class GameManager : MonoBehaviour
    {
        public static event Action<int> Damage = delegate{};


        int playerHealth;

        private void Awake()
        {
            playerHealth = 100;
            Damage.Invoke(playerHealth);
        }

        private  void SetPlayerHealth(int amount)
        {
            playerHealth += amount;
            Damage.Invoke(playerHealth);
        }

        public void AddHealth(int amount)
        {
            SetPlayerHealth(amount);
        }

        public void SubHealth(int amount)
        {
            SetPlayerHealth(amount);
        }
    }
}
