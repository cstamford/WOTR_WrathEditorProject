using Kingmaker.Visual.Animation;
using Kingmaker.Visual.Animation.Kingmaker;
using System;
using UnityEngine;

namespace Kingmaker.Visual.Animation.Kingmaker.Actions {

public class UnitAnimationActionHandEquip {
    [SerializeField] public global::Kingmaker.Visual.Animation.Kingmaker.Actions.UnitAnimationActionHandEquip.ActionType m_Type /* Kingmaker.Visual.Animation.Kingmaker.Actions.ActionType */;
    [SerializeField] public object m_Slots /* Kingmaker.Visual.Animation.Kingmaker.Actions.EquipmentSlotSetting[] */;

    public enum ActionType {
        MainHandEquip = 0,
        MainHandUnequip = 1,
        OffHandEquip = 2,
        OffHandUnequip = 3,
    }

    public class EquipmentSlotSetting {
        public object Slot /* Kingmaker.View.Equipment.UnitEquipmentAnimationSlotType */;
        public global::Kingmaker.Visual.Animation.AnimationClipWrapper ClipWrapper /* Kingmaker.Visual.Animation.AnimationClipWrapper */;
    }

}

}

