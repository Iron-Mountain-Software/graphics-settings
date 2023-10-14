using Resolution;
using UnityEditor;

namespace IronMountain.GraphicsSettings.Editor.Resolution
{
    [CustomEditor(typeof(ResolutionButton))]
    public class ResolutionButtonInspector : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            EditorGUILayout.PropertyField(serializedObject.FindProperty("width"));
            EditorGUILayout.PropertyField(serializedObject.FindProperty("height"));
            EditorGUILayout.PropertyField(serializedObject.FindProperty("aspectRatio"));
            EditorGUILayout.PropertyField(serializedObject.FindProperty("setFullScreenMode"));
            if (serializedObject.FindProperty("setFullScreenMode").boolValue)
            {
                EditorGUILayout.PropertyField(serializedObject.FindProperty("fullScreenMode"));
            }
            EditorGUILayout.PropertyField(serializedObject.FindProperty("button"));
            EditorGUILayout.PropertyField(serializedObject.FindProperty("resolutionLabel"));
            EditorGUILayout.PropertyField(serializedObject.FindProperty("aspectRatioLabel"));
            serializedObject.ApplyModifiedProperties();
        }
    }
}
