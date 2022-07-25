
using TMPro;
using UnityEngine;

namespace Nasser.io.DesignPatterns.Observer
{
    public class PlayerHealthTextController : MonoBehaviour
    {
        TMP_Text playerHealthText;
        void Start()
        {
            playerHealthText = GetComponent<TMP_Text>();
        }

         void OnDamage(int amount)
        {
            playerHealthText.text = amount.ToString();
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
