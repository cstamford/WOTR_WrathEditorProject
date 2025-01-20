using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.MVVM._CommonView.CharGen.Phases.Skills {

public class CharGenSkillAllocatorCommonView {
    [SerializeField] public object m_SkillName /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.UI.Image m_SkillIcon /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.UI.Image m_ClassSkillMark /* UnityEngine.UI.Image */;
    [SerializeField] public object m_Value /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_Modifier /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object UpButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
    [SerializeField] public object DownButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
}

}

