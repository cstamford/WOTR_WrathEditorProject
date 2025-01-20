using Kingmaker.UI.CombatText;
using System;
using UnityEngine;

namespace Kingmaker.UI.Overtip {

public class OvertipController : global::Kingmaker.UI.Overtip.OvertipControllerBase {
    [SerializeField] public global::UnityEngine.Transform m_CombatPanel /* UnityEngine.Transform */;
    [SerializeField] public global::UnityEngine.Transform m_CombatPanelHitPoints /* UnityEngine.Transform */;
    [SerializeField] public global::UnityEngine.Transform m_CombatPanelCooldown /* UnityEngine.Transform */;
    public global::Kingmaker.UI.CombatText.CombatTextManager CombatText /* Kingmaker.UI.CombatText.CombatTextManager */;
    [SerializeField] public global::Kingmaker.UI.Overtip.OvertipAction m_OvertipAction /* Kingmaker.UI.Overtip.OvertipAction */;
    [SerializeField] public object m_OvertipCooldown /* Kingmaker.UI.Overtip.OvertipCooldown */;
    [SerializeField] public object m_OvertipStandartHitPoints /* Kingmaker.UI.Overtip.OvertipStandartHitPoints */;
    [SerializeField] public object m_OvertipShortHitPoints /* Kingmaker.UI.Overtip.OvertipShortHitPoints */;
    [SerializeField] public global::Kingmaker.UI.Overtip.OvertipComponent m_OvertipName /* Kingmaker.UI.Overtip.OvertipComponent */;
    [SerializeField] public global::UnityEngine.Material m_NameSaberMaterial /* UnityEngine.Material */;
    [SerializeField] public global::UnityEngine.Color m_NameSaberColor /* UnityEngine.Color */;
    public global::UnityEngine.Sprite WalkSprite /* UnityEngine.Sprite */;
    public global::UnityEngine.Sprite AttackSprite /* UnityEngine.Sprite */;
    public global::UnityEngine.Sprite EquipSprite /* UnityEngine.Sprite */;
    public global::UnityEngine.Sprite InteractSprite /* UnityEngine.Sprite */;
    public global::UnityEngine.Sprite DefaultSprite /* UnityEngine.Sprite */;
    public bool CombatPanelVisible /* System.Boolean */;
}

}

