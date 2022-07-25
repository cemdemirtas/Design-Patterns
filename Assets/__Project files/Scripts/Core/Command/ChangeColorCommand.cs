
using UnityEngine;
namespace Nasser.io.DesignPatterns
{
    public class ChangeColorCommand : ICommand
    {
        LightBulpController bulpController;

        Color previousColor;
        public ChangeColorCommand(LightBulpController _lightBulp)
        {
            bulpController = _lightBulp;
            previousColor = _lightBulp.transform.GetChild(1).GetComponent<Renderer>().material.GetColor("_EmissionColor"); ;
        }
        public void Execute()
        {
            bulpController.ChangeColor();
        }

        public void Undo()
        {
           bulpController.SetLightColor(previousColor);
        }
    }
}
