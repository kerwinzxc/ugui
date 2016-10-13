using UnityEngine;
using UnityEngine.PenguinUI;

namespace UnityEditor.PenguinUI
{
    [CustomEditor(typeof(ContentSizeFitter), true)]
    [CanEditMultipleObjects]
    public class ContentSizeFitterEditor : SelfControllerEditor
    {
        SerializedProperty m_HorizontalFit;
        SerializedProperty m_VerticalFit;

        protected virtual void OnEnable()
        {
            m_HorizontalFit = serializedObject.FindProperty("m_HorizontalFit");
            m_VerticalFit = serializedObject.FindProperty("m_VerticalFit");
        }

        public override void OnInspectorGUI()
        {
            serializedObject.Update();
            EditorGUILayout.PropertyField(m_HorizontalFit, true);
            EditorGUILayout.PropertyField(m_VerticalFit, true);
            serializedObject.ApplyModifiedProperties();

            base.OnInspectorGUI();
        }
    }
}
