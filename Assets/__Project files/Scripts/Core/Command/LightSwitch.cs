using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nasser.io.DesignPatterns
{
    // Invoker of command 


    public class LightSwitch
    {
        ICommand onCommand;
        public LightSwitch(ICommand _onCommand)
        {
            onCommand = _onCommand;
        }

        public void TogglePower()
        {
            onCommand.Execute();
        }
        
    }
}
