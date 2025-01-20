using System;
using UnityEngine;

namespace Kingmaker.UI._ConsoleUI.Overtips {

public class UnitOvertipView : global::Kingmaker.UI._ConsoleUI.Overtips.OvertipViewBase {
    [SerializeField] public global::UnityEngine.Transform m_CombatPanel /* UnityEngine.Transform */;
    [SerializeField] public global::UnityEngine.Transform m_CombatPanelHitPoints /* UnityEngine.Transform */;
    [SerializeField] public global::UnityEngine.Transform m_CombatPanelCooldown /* UnityEngine.Transform */;
    public global::Kingmaker.UI._ConsoleUI.Overtips.OvertipViewPartCombatText CombatText /* Kingmaker.UI._ConsoleUI.Overtips.OvertipViewPartCombatText */;
    public float TweenDuration /* System.Single */;
    [SerializeField] public global::Kingmaker.UI._ConsoleUI.Overtips.OvertipViewPartName m_OvertipViewPartName /* Kingmaker.UI._ConsoleUI.Overtips.OvertipViewPartName */;
    [SerializeField] public global::Kingmaker.UI._ConsoleUI.Overtips.OvertipViewPartAction m_OvertipAction /* Kingmaker.UI._ConsoleUI.Overtips.OvertipViewPartAction */;
    [SerializeField] public global::Kingmaker.UI._ConsoleUI.Overtips.OvertipViewPartCooldown m_OvertipCooldown /* Kingmaker.UI._ConsoleUI.Overtips.OvertipViewPartCooldown */;
    [SerializeField] public global::Kingmaker.UI._ConsoleUI.Overtips.OvertipViewPartStandartHitPoints m_OvertipStandartHitPoints /* Kingmaker.UI._ConsoleUI.Overtips.OvertipViewPartStandartHitPoints */;
    [SerializeField] public global::Kingmaker.UI._ConsoleUI.Overtips.OvertipViewPartShortHitPoints m_OvertipShortHitPoints /* Kingmaker.UI._ConsoleUI.Overtips.OvertipViewPartShortHitPoints */;
    public global::Kingmaker.UI._ConsoleUI.Overtips.OvertipViewPartSpellHandle SpellOvertipViewPrefab /* Kingmaker.UI._ConsoleUI.Overtips.OvertipViewPartSpellHandle */;
    public global::Kingmaker.UI._ConsoleUI.Overtips.OvertipViewPartBark OvertipViewPartBarkPrefab /* Kingmaker.UI._ConsoleUI.Overtips.OvertipViewPartBark */;
    [SerializeField] public float m_OvertipPosY /* System.Single */;
    public bool CombatPanelVisible /* System.Boolean */;
}

}

