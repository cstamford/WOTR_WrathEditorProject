using Kingmaker.Visual.Animation;
using System;
using UnityEngine;

namespace Kingmaker.UI.ServiceWindow {

public class DollRoom : MonoBehaviour {
    [SerializeField] public Transform m_CharacterPlaceholder /* UnityEngine.Transform */;
    [SerializeField] public DollRoomCharacterController m_CharacterController /* Kingmaker.UI.ServiceWindow.DollRoomCharacterController */;
    [SerializeField] public DollCamera m_Camera /* Kingmaker.UI.ServiceWindow.DollCamera */;
    [SerializeField] public bool m_UseCustomAnimationSets /* System.Boolean */;
    [SerializeField] public object m_CustomAnimationSets /* Kingmaker.Blueprints.Reference[] */;
    [SerializeField] public bool m_KeepHandsFree /* System.Boolean */;
    [SerializeField] public object m_CustomFreeHands /* Kingmaker.UI.ServiceWindow.ClassGroupAnimations[] */;
    [SerializeField] public Light[] m_DisabledLights /* UnityEngine.Light[] */;
    [SerializeField] public AnimationClipWrapper m_RightHandedAnimationWrapper /* Kingmaker.Visual.Animation.AnimationClipWrapper */;
    public GameObject Platform /* UnityEngine.GameObject */;

    public class ClassGroupAnimations {
        [SerializeField] public object ClassGroup /* Kingmaker.Blueprints.BlueprintCharacterClassGroupReference */;
        public object MicroIdle /* Kingmaker.Visual.Animation.Kingmaker.Actions.UnitAnimationActionMicroIdle */;
        public object LocoMotionHuman /* Kingmaker.Visual.Animation.Kingmaker.Actions.UnitAnimationActionLocoMotionHuman */;
    }

}

}

