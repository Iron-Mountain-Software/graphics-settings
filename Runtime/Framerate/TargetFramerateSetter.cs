using UnityEngine;

namespace Framerate
{
    public class TargetFramerateSetter : MonoBehaviour
    {
        [SerializeField] private int targetFrameRate;
    
        private void OnEnable()
        {
            Application.targetFrameRate = targetFrameRate;
        }
    }
}
