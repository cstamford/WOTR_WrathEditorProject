using Kingmaker.Visual.Animation.Kingmaker;
using System;
using UnityEngine;

namespace Kingmaker.Visual.Animation.Kingmaker.Actions {

public class UnitAnimationActionLocoMotion {
    [SerializeField] public global::UnityEngine.RuntimeAnimatorController m_AnimatorController /* UnityEngine.RuntimeAnimatorController */;
    [SerializeField] public bool m_HasMoveType /* System.Boolean */;
    [SerializeField] public bool m_HasStopping /* System.Boolean */;
    [SerializeField] public bool m_HasOffset /* System.Boolean */;
    [SerializeField] public int m_DefaultLayerIndex /* System.Int32 */;
    [SerializeField] public object m_WeaponStyleOverrides /* Kingmaker.Visual.Animation.Kingmaker.Actions.WeaponStyleLayer[] */;
    [SerializeField] public bool m_HasStealthAnimations /* System.Boolean */;
    [SerializeField] public float DefaultSpeedMps /* System.Single */;

    public enum WalkSpeedType {
        Slow = 0,
        Normal = 1,
        Charge = 2,
        Stealth = 3,
    }

    public class WeaponStyleLayer {
        public object Style /* Kingmaker.View.Animation.WeaponAnimationStyle */;
        public global::Kingmaker.Visual.Animation.Kingmaker.Actions.UnitAnimationActionLocoMotion.WeaponStyleLayer.Override OverrideType /* Kingmaker.Visual.Animation.Kingmaker.Actions.Override */;
        public int MainHandLayerIndex /* System.Int32 */;
        public int OffHandLayerIndex /* System.Int32 */;

        public enum Override {
            BothHands = 0,
            MainHand = 1,
            OffHand = 2,
        }

    }

}

}

