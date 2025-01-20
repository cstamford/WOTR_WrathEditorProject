using Kingmaker.Visual;
using Kingmaker.Visual.CharactersRigidbody;
using System;
using UnityEngine;

namespace Kingmaker.View {

public class UnitEntityView {
    [SerializeField] public float m_SoftColliderHeight /* System.Single */;
    [SerializeField] public bool m_HorizontalCollider /* System.Boolean */;
    [SerializeField] public float m_SoftColliderRadius /* System.Single */;
    [SerializeField] public global::UnityEngine.CapsuleCollider m_SoftCollider /* UnityEngine.CapsuleCollider */;
    [SerializeField] public global::UnityEngine.MeshCollider m_CoreCollider /* UnityEngine.MeshCollider */;
    public global::Kingmaker.Visual.CharactersRigidbody.RigidbodyCreatureController RigidbodyController /* Kingmaker.Visual.CharactersRigidbody.RigidbodyCreatureController */;
    public global::UnityEngine.Vector3 OverrideDollRoomScale /* UnityEngine.Vector3 */;
    [SerializeField] public float m_Corpulence /* System.Single */;
    public bool ForbidRotation /* System.Boolean */;
    [SerializeField] public object m_AnimationSettings /* Kingmaker.View.Animation.UnitAnimationSettings */;
    [SerializeField] public bool m_IgnoreRaceAnimationSettings /* System.Boolean */;
    public global::Kingmaker.Visual.BloodyFaceController BloodyController /* Kingmaker.Visual.BloodyFaceController */;
    [SerializeField] public global::UnityEngine.GameObject m_BuiltinArmorMediumView /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.GameObject m_BuiltinArmorHeavyView /* UnityEngine.GameObject */;
    public bool IsOptimizationDummy /* System.Boolean */;
    public bool IsInDollRoom /* System.Boolean */;
}

}

