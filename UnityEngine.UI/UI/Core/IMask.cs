using System;

namespace UnityEngine.PenguinUI
{
    [Obsolete("Not supported anymore.", true)]
    public interface IMask
    {
        bool Enabled();
        RectTransform rectTransform { get; }
    }
}
