using Kingmaker.UI.Common;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI._ConsoleUI.TurnBasedMode {

public class InitiativeTrackerUnitBaseView {
    [SerializeField] public global::Kingmaker.UI._ConsoleUI.TurnBasedMode.InitiativeTrackerPortraitZone m_CharacetrPortraitZone /* Kingmaker.UI._ConsoleUI.TurnBasedMode.InitiativeTrackerPortraitZone */;
    [SerializeField] public global::Kingmaker.UI._ConsoleUI.TurnBasedMode.InitiativeTrackerPortraitZone m_NPCPortraitZone /* Kingmaker.UI._ConsoleUI.TurnBasedMode.InitiativeTrackerPortraitZone */;
    [SerializeField] public global::UnityEngine.GameObject m_HealthTextContainer /* UnityEngine.GameObject */;
    [SerializeField] public object m_HealthText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_HealthShortText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_NameNormal /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.Color m_FriendlyColor /* UnityEngine.Color */;
    [SerializeField] public global::UnityEngine.Color m_EnemyColor /* UnityEngine.Color */;
    [SerializeField] public global::Kingmaker.UI.Common.WidgetListMultiMVVM m_BuffWidjetList /* Kingmaker.UI.Common.WidgetListMultiMVVM */;
    [SerializeField] public global::Kingmaker.UI._ConsoleUI.TurnBasedMode.InitiativeTrackerBuffView m_BuffViewPrefab /* Kingmaker.UI._ConsoleUI.TurnBasedMode.InitiativeTrackerBuffView */;
    [SerializeField] public int MaxBuffs /* System.Int32 */;
    [SerializeField] public global::UnityEngine.GameObject m_OverlookingArrow /* UnityEngine.GameObject */;
    [SerializeField] public object m_Initiative /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.GameObject m_EnemyMarker /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.GameObject[] m_UnableToFilling /* UnityEngine.GameObject[] */;
    [SerializeField] public global::UnityEngine.GameObject m_IsLossControlIcon /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.GameObject m_HasLossControlEffectsIcon /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.UI.Image m_PesonalEncumbranceIcon /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.UI.Image m_PartyEncumbranceIcon /* UnityEngine.UI.Image */;
}

}

