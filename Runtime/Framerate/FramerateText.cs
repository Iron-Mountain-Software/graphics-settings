using UnityEngine;
using UnityEngine.UI;

namespace Framerate
{
    [DisallowMultipleComponent]
    [RequireComponent(typeof(Text))]
    public class FramerateText : MonoBehaviour
    {
        [SerializeField] private Text text;
        [SerializeField] private float secondsBetweenCalculations = .2f;

        private int _frames = 0;
        private float _time;

        private void Awake()
        {
            if (!text) text = GetComponent<Text>();
        }

        private void OnValidate()
        {
            if (!text) text = GetComponent<Text>();
        }

        private void Update()
        {
            _frames++;
            float elapsedSeconds = Time.unscaledTime - _time;
            if (elapsedSeconds > secondsBetweenCalculations)
            {
                if (text) text.text = (_frames / elapsedSeconds).ToString(".00") + " FPS";
                _frames = 0;
                _time = Time.unscaledTime;
            }
        }
    }
}
