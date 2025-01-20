using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.MVVM._PCView.CombatLog {

public class CombatLogItemBaseView {
    [SerializeField] public object m_Text /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.GameObject m_PrefixIconContainer /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.UI.Image[] m_PrefixIcons /* UnityEngine.UI.Image[] */;
    [SerializeField] public object m_VirtualListSettings /* Owlcat.Runtime.UI.VirtualListSystem.ElementSettings.VirtualListLayoutElementSettings */;
}

}

