using UnityEngine.PenguinUI;

namespace UnityEditor.PenguinUI
{
    [CustomEditor(typeof(Button), true)]
    [CanEditMultipleObjects]
    public class ButtonEditor : SelectableEditor
    {
        SerializedProperty m_OnClickProperty;

        protected override void OnEnable()
        {
            base.OnEnable();
            m_OnClickProperty = serializedObject.FindProperty("m_OnClick");
        }

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            EditorGUILayout.Space();

            serializedObject.Update();
            EditorGUILayout.PropertyField(m_OnClickProperty);
            serializedObject.ApplyModifiedProperties();
        }
    }
}
