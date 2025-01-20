using Kingmaker.UI;
using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UI.Extensions;

namespace Kingmaker.UI.MVVM._PCView.ActionBar {

public class ActionBarBaseSlotView {
    [SerializeField] public object m_MainButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
    [SerializeField] public global::Kingmaker.UI.UIHighlighter m_Highlighter /* Kingmaker.UI.UIHighlighter */;
    [SerializeField] public global::UnityEngine.UI.Image m_Icon /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.UI.Extensions.UICornerCut m_ForeIcon /* UnityEngine.UI.Extensions.UICornerCut */;
    [SerializeField] public global::UnityEngine.UI.Image m_Decoration /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.UI.Image m_Disable /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.UI.Image m_ActiveMark /* UnityEngine.UI.Image */;
    [SerializeField] public object m_ResourceCount /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.UI.Image m_ResourceCountShadow /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.RectTransform m_SplashAnim /* UnityEngine.RectTransform */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ActionBar.ActionBarConvertedView m_ConvertedView /* Kingmaker.UI.MVVM._PCView.ActionBar.ActionBarConvertedView */;
    [SerializeField] public object m_ConvertButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
}

}

