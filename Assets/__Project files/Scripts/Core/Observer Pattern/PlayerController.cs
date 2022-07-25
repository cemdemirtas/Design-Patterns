
using UnityEngine;

namespace Nasser.io.DesignPatterns.Observer
{
    public class PlayerController : MonoBehaviour
    {
        int health;

        public void SetPlayerHealth(int addedAmount)
        {

            health += addedAmount;
        }

        public int GetPlayerHealth()
        {
            return health;
        }

        void OnDamage(int amount)
        {
            health = amount;
            Debug.Log("Player health"  + health);   
        }

        private void OnEnable()
        {
            GameManager.Damage += OnDamage;
        }

        private void OnDisable()
        {
            GameManager.Damage -= OnDamage;
        }
    }
}
