using Kingmaker.Visual.Animation;
using Kingmaker.Visual.Animation.Kingmaker.Actions;
using System;
using UnityEngine;

namespace Kingmaker.UI.ServiceWindow {

public class DollRoom : global::UnityEngine.MonoBehaviour {
    [SerializeField] public global::UnityEngine.Transform m_CharacterPlaceholder /* UnityEngine.Transform */;
    [SerializeField] public global::Kingmaker.UI.ServiceWindow.DollRoomCharacterController m_CharacterController /* Kingmaker.UI.ServiceWindow.DollRoomCharacterController */;
    [SerializeField] public global::Kingmaker.UI.ServiceWindow.DollCamera m_Camera /* Kingmaker.UI.ServiceWindow.DollCamera */;
    [SerializeField] public bool m_UseCustomAnimationSets /* System.Boolean */;
    [SerializeField] public object m_CustomAnimationSets /* Kingmaker.Blueprints.Reference[] */;
    [SerializeField] public bool m_KeepHandsFree /* System.Boolean */;
    [SerializeField] public object m_CustomFreeHands /* Kingmaker.UI.ServiceWindow.ClassGroupAnimations[] */;
    [SerializeField] public global::UnityEngine.Light[] m_DisabledLights /* UnityEngine.Light[] */;
    [SerializeField] public global::Kingmaker.Visual.Animation.AnimationClipWrapper m_RightHandedAnimationWrapper /* Kingmaker.Visual.Animation.AnimationClipWrapper */;
    public global::UnityEngine.GameObject Platform /* UnityEngine.GameObject */;

    public class ClassGroupAnimations {
        [SerializeField] public object ClassGroup /* Kingmaker.Blueprints.BlueprintCharacterClassGroupReference */;
        public global::Kingmaker.Visual.Animation.Kingmaker.Actions.UnitAnimationActionMicroIdle MicroIdle /* Kingmaker.Visual.Animation.Kingmaker.Actions.UnitAnimationActionMicroIdle */;
        public global::Kingmaker.Visual.Animation.Kingmaker.Actions.UnitAnimationActionLocoMotionHuman LocoMotionHuman /* Kingmaker.Visual.Animation.Kingmaker.Actions.UnitAnimationActionLocoMotionHuman */;
    }

}

}

