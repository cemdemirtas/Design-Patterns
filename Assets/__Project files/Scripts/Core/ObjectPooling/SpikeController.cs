using DG.Tweening;
using UnityEngine;

namespace Nasser.io.DesignPatterns.Pool
{
    public class SpikeController : MonoBehaviour
    {
        private void Start()
        {
            transform.DOShakeScale(1).SetLoops(-1).SetEase(Ease.Linear);
            
        }
    }
}
