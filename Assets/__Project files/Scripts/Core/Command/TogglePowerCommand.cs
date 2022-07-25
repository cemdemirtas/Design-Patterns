using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nasser.io.DesignPatterns
{
    public class TogglePowerCommand : ICommand
    {
        LightBulpController bulpController;
        public TogglePowerCommand(LightBulpController _lightBulp)
        {
            bulpController = _lightBulp;
        }
        public void Execute()
        {
            bulpController.TogglePower();
        }

        public void Undo()
        {
            bulpController.TogglePower();
        }
    }
}
