using Kingmaker.UI.Common.Animations;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI._ConsoleUI.Overtips {

public class OvertipViewPartAction : global::Kingmaker.UI._ConsoleUI.Overtips.OvertipViewPartBase {
    [SerializeField] public global::UnityEngine.UI.Image[] m_ColorizableElements /* UnityEngine.UI.Image[] */;
    [SerializeField] public global::UnityEngine.UI.Image m_ActionIcon /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.UI.Image m_Background /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.Sprite m_EnemyBackground /* UnityEngine.Sprite */;
    [SerializeField] public global::UnityEngine.Sprite m_AllyBackground /* UnityEngine.Sprite */;
    [SerializeField] public global::UnityEngine.Sprite m_DefaultBackground /* UnityEngine.Sprite */;
    public global::UnityEngine.Sprite WalkSprite /* UnityEngine.Sprite */;
    public global::UnityEngine.Sprite AttackSprite /* UnityEngine.Sprite */;
    public global::UnityEngine.Sprite EquipSprite /* UnityEngine.Sprite */;
    public global::UnityEngine.Sprite InteractSprite /* UnityEngine.Sprite */;
    public global::UnityEngine.Sprite DefaultSprite /* UnityEngine.Sprite */;
    public global::UnityEngine.CanvasGroup NamePanel /* UnityEngine.CanvasGroup */;
    public bool UnitWalk /* System.Boolean */;
    public object TurnBasedCommad /* System.Nullable */;
    public global::UnityEngine.Sprite TurnBasedAbilityIcon /* UnityEngine.Sprite */;
    public global::UnityEngine.UI.Image Cooldown /* UnityEngine.UI.Image */;
    public global::UnityEngine.UI.Image CooldownShadow /* UnityEngine.UI.Image */;
    public global::UnityEngine.GameObject LowHitPointNotification /* UnityEngine.GameObject */;
    public float PercentToShowLowHitPoint /* System.Single */;
    [SerializeField] public object m_DestroyAnimator /* Kingmaker.UI.Common.Animations.DestroyAnimator[] */;
    [SerializeField] public global::Kingmaker.UI.Common.Animations.FadeAnimator m_Fastener /* Kingmaker.UI.Common.Animations.FadeAnimator */;
}

}

