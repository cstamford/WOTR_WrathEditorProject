using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.ServiceWindow {

public class SpellBookView : global::UnityEngine.MonoBehaviour {
    [SerializeField] public global::Kingmaker.UI.ServiceWindow.SpellBookToggle ClassToggle /* Kingmaker.UI.ServiceWindow.SpellBookToggle */;
    [SerializeField] public global::Kingmaker.UI.ServiceWindow.SpellBookLevelTabs LevelBookSwitcher /* Kingmaker.UI.ServiceWindow.SpellBookLevelTabs */;
    [SerializeField] public object m_LevelNumberLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_LevelLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_SlotsSubstituteText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.GameObject m_ButtonNextPageOff /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.UI.Button m_ButtonNextPage /* UnityEngine.UI.Button */;
    [SerializeField] public global::UnityEngine.GameObject m_ButtonPrevPageOff /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.UI.Button m_ButtonPrevPage /* UnityEngine.UI.Button */;
    [SerializeField] public global::UnityEngine.GameObject m_ContainerBigHeader /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.GameObject[] m_SpellsContainers /* UnityEngine.GameObject[] */;
    [SerializeField] public global::UnityEngine.UI.ToggleGroup m_ShowedSpells /* UnityEngine.UI.ToggleGroup */;
    [SerializeField] public object m_CasterClassName /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_CasterDeity /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.Transform m_DeterminatorsComntainer /* UnityEngine.Transform */;
    [SerializeField] public global::UnityEngine.Transform m_FavoriteScoolIconsContainer /* UnityEngine.Transform */;
    [SerializeField] public global::UnityEngine.Transform m_DomainIconsContainer /* UnityEngine.Transform */;
    [SerializeField] public global::UnityEngine.Transform m_OppositeSchoolContainer /* UnityEngine.Transform */;
    public int CurrentPageIndex /* System.Int32 */;
    public int CurrentBookLevel /* System.Int32 */;
}

}

