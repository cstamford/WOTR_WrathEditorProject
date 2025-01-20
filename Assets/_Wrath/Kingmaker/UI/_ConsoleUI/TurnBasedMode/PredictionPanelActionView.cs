using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI._ConsoleUI.TurnBasedMode {

public class PredictionPanelActionView {
    [SerializeField] public global::Kingmaker.UI._ConsoleUI.TurnBasedMode.ActionViewElement m_Action /* Kingmaker.UI._ConsoleUI.TurnBasedMode.ActionViewElement */;
    [SerializeField] public global::UnityEngine.GameObject m_AvailibleActions /* UnityEngine.GameObject */;
    [SerializeField] public global::Kingmaker.UI._ConsoleUI.TurnBasedMode.ActionViewElement m_Move /* Kingmaker.UI._ConsoleUI.TurnBasedMode.ActionViewElement */;
    [SerializeField] public global::Kingmaker.UI._ConsoleUI.TurnBasedMode.ActionViewElement m_Attack /* Kingmaker.UI._ConsoleUI.TurnBasedMode.ActionViewElement */;
    [SerializeField] public global::Kingmaker.UI._ConsoleUI.TurnBasedMode.ActionViewElement m_Ability /* Kingmaker.UI._ConsoleUI.TurnBasedMode.ActionViewElement */;
    [SerializeField] public global::UnityEngine.GameObject m_AbilityIconPlace /* UnityEngine.GameObject */;
    [SerializeField] public global::Kingmaker.UI._ConsoleUI.TurnBasedMode.ActionViewElement m_AbilityIconElement /* Kingmaker.UI._ConsoleUI.TurnBasedMode.ActionViewElement */;
    [SerializeField] public global::UnityEngine.UI.Image m_AbilityIcon /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.GameObject m_CurrentAction /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.GameObject m_CurrentActivity /* UnityEngine.GameObject */;
    [SerializeField] public global::Kingmaker.UI._ConsoleUI.TurnBasedMode.ActionViewElement m_MoveActivity /* Kingmaker.UI._ConsoleUI.TurnBasedMode.ActionViewElement */;
    [SerializeField] public global::Kingmaker.UI._ConsoleUI.TurnBasedMode.ActionViewElement m_AttackActivity /* Kingmaker.UI._ConsoleUI.TurnBasedMode.ActionViewElement */;
    [SerializeField] public global::Kingmaker.UI._ConsoleUI.TurnBasedMode.ActionViewElement m_AbilityActivity /* Kingmaker.UI._ConsoleUI.TurnBasedMode.ActionViewElement */;
    [SerializeField] public object m_ActionText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_ActionValue /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_ActionNameText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.GameObject m_DistanceSliderContainer /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.UI.Slider m_RemainingDistanceSlider /* UnityEngine.UI.Slider */;
    [SerializeField] public global::UnityEngine.UI.Slider m_PredictionDistanceSlider /* UnityEngine.UI.Slider */;
}

}

