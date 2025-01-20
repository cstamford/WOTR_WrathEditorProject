using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UI.Extensions;

namespace Kingmaker.UI.MVVM._ConsoleView.ActionBar {

public class ActionBarSelectorItemView {
    [SerializeField] public object m_FocusMultiButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
    [SerializeField] public global::UnityEngine.UI.Image m_Icon /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.UI.Extensions.UICornerCut m_ForeIcon /* UnityEngine.UI.Extensions.UICornerCut */;
    [SerializeField] public object m_Title /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_Description /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_SchoolName /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_Level /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.UI.Image m_Decoration /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.GameObject m_LevelContainer /* UnityEngine.GameObject */;
}

}

