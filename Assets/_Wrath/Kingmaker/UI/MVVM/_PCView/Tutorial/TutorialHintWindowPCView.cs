using Kingmaker.UI.Common;
using Kingmaker.UI.MVVM._PCView.Other;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.MVVM._PCView.Tutorial {

public class TutorialHintWindowPCView {
    [SerializeField] public global::Kingmaker.UI.Common.ScrollRectExtended m_ScrollRect /* Kingmaker.UI.Common.ScrollRectExtended */;
    [SerializeField] public int m_ViewPortHeight /* System.Int32 */;
    [SerializeField] public global::UnityEngine.UI.LayoutElement m_ViewPort /* UnityEngine.UI.LayoutElement */;
    [SerializeField] public global::UnityEngine.RectTransform m_Content /* UnityEngine.RectTransform */;
    [SerializeField] public global::UnityEngine.GameObject m_SolutionContainer /* UnityEngine.GameObject */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Other.EntityPCView m_SolutionEntity /* Kingmaker.UI.MVVM._PCView.Other.EntityPCView */;
}

}

