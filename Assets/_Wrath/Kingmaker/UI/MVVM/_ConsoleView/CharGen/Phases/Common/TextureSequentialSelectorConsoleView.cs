using Kingmaker.UI.MVVM._PCView.Other;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.MVVM._ConsoleView.CharGen.Phases.Common {

public class TextureSequentialSelectorConsoleView {
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Other.ConsoleSelectableButton SelectableButton /* Kingmaker.UI.MVVM._PCView.Other.ConsoleSelectableButton */;
    [SerializeField] public global::UnityEngine.UI.Image m_CurrentValue /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.GameObject m_NextArrow /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.GameObject m_PrevArrow /* UnityEngine.GameObject */;
    [SerializeField] public object m_Counter /* TMPro.TextMeshProUGUI */;
}

}

