using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.ServiceWindow {

public class SpellBookView : MonoBehaviour {
    [SerializeField] public SpellBookToggle ClassToggle /* Kingmaker.UI.ServiceWindow.SpellBookToggle */;
    [SerializeField] public SpellBookLevelTabs LevelBookSwitcher /* Kingmaker.UI.ServiceWindow.SpellBookLevelTabs */;
    [SerializeField] public object m_LevelNumberLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_LevelLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_SlotsSubstituteText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public GameObject m_ButtonNextPageOff /* UnityEngine.GameObject */;
    [SerializeField] public Button m_ButtonNextPage /* UnityEngine.UI.Button */;
    [SerializeField] public GameObject m_ButtonPrevPageOff /* UnityEngine.GameObject */;
    [SerializeField] public Button m_ButtonPrevPage /* UnityEngine.UI.Button */;
    [SerializeField] public GameObject m_ContainerBigHeader /* UnityEngine.GameObject */;
    [SerializeField] public GameObject[] m_SpellsContainers /* UnityEngine.GameObject[] */;
    [SerializeField] public ToggleGroup m_ShowedSpells /* UnityEngine.UI.ToggleGroup */;
    [SerializeField] public object m_CasterClassName /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_CasterDeity /* TMPro.TextMeshProUGUI */;
    [SerializeField] public Transform m_DeterminatorsComntainer /* UnityEngine.Transform */;
    [SerializeField] public Transform m_FavoriteScoolIconsContainer /* UnityEngine.Transform */;
    [SerializeField] public Transform m_DomainIconsContainer /* UnityEngine.Transform */;
    [SerializeField] public Transform m_OppositeSchoolContainer /* UnityEngine.Transform */;
    public int CurrentPageIndex /* System.Int32 */;
    public int CurrentBookLevel /* System.Int32 */;
}

}

