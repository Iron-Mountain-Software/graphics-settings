using UnityEngine;
using UnityEngine.UI;

namespace Resolution
{
    [RequireComponent(typeof(Toggle))]
    public class FullScreenToggle : MonoBehaviour
    {
        [SerializeField] private Toggle toggle;

        private void Awake()
        {
            if (!toggle) toggle = GetComponent<Toggle>();
        }

        private void OnValidate()
        {
            if (!toggle) toggle = GetComponent<Toggle>();
        }

        private void OnEnable()
        {
            if (!toggle) return;
            toggle.isOn = Screen.fullScreen;
            toggle.onValueChanged.AddListener(OnClick);
        }

        private void OnDisable()
        {
            if (!toggle) return;
            toggle.onValueChanged.RemoveListener(OnClick);
        }

        private void OnClick(bool state)
        {
            if (state)
            {
                Screen.fullScreenMode = Application.platform switch
                {
                    RuntimePlatform.OSXPlayer => FullScreenMode.MaximizedWindow,
                    RuntimePlatform.WindowsPlayer => FullScreenMode.ExclusiveFullScreen,
                    _ => FullScreenMode.FullScreenWindow
                };
            }
            else Screen.fullScreenMode = FullScreenMode.Windowed;
        }
    }
}
