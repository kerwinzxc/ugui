using UnityEngine;
using UnityEngine.PenguinUI;

namespace UnityEditor.PenguinUI
{
    [InitializeOnLoad]
    internal class PrefabLayoutRebuilder
    {
        static PrefabLayoutRebuilder()
        {
            PrefabUtility.prefabInstanceUpdated += OnPrefabInstanceUpdates;
        }

        static void OnPrefabInstanceUpdates(GameObject instance)
        {
            if (instance)
            {
                RectTransform rect = instance.transform as RectTransform;
                if (rect)
                    LayoutRebuilder.MarkLayoutForRebuild(rect);
            }
        }
    }
}
