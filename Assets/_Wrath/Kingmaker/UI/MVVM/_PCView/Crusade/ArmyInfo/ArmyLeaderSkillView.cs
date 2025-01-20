using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.MVVM._PCView.Crusade.ArmyInfo {

public class ArmyLeaderSkillView {
    [SerializeField] public object m_Selectable /* Owlcat.Runtime.UI.Controls.Selectable.OwlcatMultiSelectable */;
    [SerializeField] public global::UnityEngine.UI.Image m_Icon /* UnityEngine.UI.Image */;
    [SerializeField] public object m_SkillName /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.GameObject m_SelectedLayer /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.GameObject m_CountBlock /* UnityEngine.GameObject */;
    [SerializeField] public object m_Count /* TMPro.TextMeshProUGUI */;
}

}

