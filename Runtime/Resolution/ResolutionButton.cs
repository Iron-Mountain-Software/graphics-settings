using UnityEngine;
using UnityEngine.UI;

namespace Resolution
{
    [RequireComponent(typeof(Button))]
    public class ResolutionButton : MonoBehaviour
    {
        [SerializeField] private int width; 
        [SerializeField] private int height;
        [SerializeField] private string aspectRatio;
        [SerializeField] private bool setFullScreenMode;
        [SerializeField] private FullScreenMode fullScreenMode;
        [SerializeField] private Button button;
        [SerializeField] private Text resolutionLabel;
        [SerializeField] private Text aspectRatioLabel;

        public int Width
        {
            get => width;
            set
            {
                width = value;
                RefreshResolutionLabel();
            }
        }

        public int Height
        {
            get => height;
            set
            {
                height = value;
                RefreshResolutionLabel();
            }
        }
        
        public string AspectRatio
        {
            get => aspectRatio;
            set
            {
                aspectRatio = value;
                RefreshAspectRatioLabel();
            }
        }

        private void Awake()
        {
            if (!button) button = GetComponent<Button>();
        }

        private void OnValidate()
        {
            if (!button) button = GetComponent<Button>();
            RefreshResolutionLabel();
            RefreshAspectRatioLabel();
        }

        private void OnEnable()
        {
            if (button) button.onClick.AddListener(OnClick);
            RefreshResolutionLabel();
            RefreshAspectRatioLabel();
        }

        private void OnDisable()
        {
            if (button) button.onClick.RemoveListener(OnClick);
        }

        private void RefreshResolutionLabel()
        {
            if (resolutionLabel) resolutionLabel.text = width + "x" + height;
        }
        
        private void RefreshAspectRatioLabel()
        {
            if (aspectRatioLabel) aspectRatioLabel.text = aspectRatio;
        }

        private void OnClick()
        {
            FullScreenMode newFullScreenMode = setFullScreenMode ? fullScreenMode : Screen.fullScreenMode;
            Screen.SetResolution(width, height, newFullScreenMode);
        }
    }
}
