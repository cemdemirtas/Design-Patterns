
using UnityEngine;
using TMPro;
using UnityEngine.UI;

namespace Nasser.io.DesignPatterns.SINGLETON
{
    public class GameManagerSingleton : SINGLETON<GameManagerSingleton>
    {
        [SerializeField] TMP_Text playerHealthText;
        [SerializeField] Image playerHealthImage;

        private  void SetPlayerHealth()
        {
            playerHealthText.text = PlayerSingleton.instance.GetPlayerHealth().ToString();
            playerHealthImage.fillAmount = PlayerSingleton.instance.GetPlayerHealth()/ 100f;
        }

        public void AddHealth()
        {
            PlayerSingleton.instance.SetPlayerHealth(10);
            SetPlayerHealth();
        }

        public void SubHealth()
        {
            PlayerSingleton.instance.SetPlayerHealth(-10);
            SetPlayerHealth();
        }
    }
}
