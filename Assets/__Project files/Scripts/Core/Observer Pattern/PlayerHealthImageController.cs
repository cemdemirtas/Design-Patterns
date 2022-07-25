
using UnityEngine;
using UnityEngine.UI;

namespace Nasser.io.DesignPatterns.Observer
{
    public class PlayerHealthImageController : MonoBehaviour
    {
        Image playerHealthImage;

        void Start()
        {
        playerHealthImage = GetComponent<Image>();
        }

        void OnDamage(int amount)
        {
            playerHealthImage.fillAmount = amount / 100f;
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
