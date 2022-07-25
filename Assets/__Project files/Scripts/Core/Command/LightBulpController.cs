using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nasser.io.DesignPatterns
{
    public class LightBulpController : MonoBehaviour
    {
        GameObject lightObj;
        Material lightMat;
        bool isLightOn = false;
        private void Awake()
        {
            lightObj = transform.GetChild(1).gameObject;
            lightObj.SetActive(false);

            lightMat = transform.GetChild(1).GetComponent<Renderer>().material;
        }
        public void TogglePower()
        {
            lightObj.SetActive(isLightOn = !isLightOn);
        }

        public void SetLightColor(Color color)
        {
            lightMat.SetColor("_EmissionColor", color);
        }
        public void ChangeColor()
        {
            Color rnadomColor = Random.ColorHSV(0f, 1f, 1f, 1f, .5f, 1f);
            lightMat.SetColor("_EmissionColor", rnadomColor);
        }
    }
}
