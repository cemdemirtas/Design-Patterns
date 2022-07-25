using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nasser.io.DesignPatterns
{
    public class UIController : MonoBehaviour
    {
        [SerializeField] LightBulpController bulp;

        LightApp LightApp;

        private void Start()
        {
            
            LightApp = new LightApp();
        }
        public void OpenLight()
        {
            ICommand TogglePowerCommand = new TogglePowerCommand(bulp);
            LightApp.AddCommand(TogglePowerCommand);
        }
        public void ChangeColor()
        {
            ICommand changeColorCommand= new ChangeColorCommand(bulp);
            LightApp.AddCommand(changeColorCommand);
        }

        public void UndoCommand()
        {
            LightApp.UndoCommand();
        }
    }
}
