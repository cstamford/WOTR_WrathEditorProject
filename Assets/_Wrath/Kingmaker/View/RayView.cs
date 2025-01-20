using System;
using UnityEngine;

namespace Kingmaker.View {

public class RayView : global::UnityEngine.MonoBehaviour {
    [SerializeField] public object m_Trajectory /* Kingmaker.Blueprints.BlueprintProjectileTrajectoryReference */;
    [SerializeField] public float m_DistanceBetweenVertices /* System.Single */;
    [SerializeField] public bool m_SnapToGround /* System.Boolean */;
    [SerializeField] public float m_Delay /* System.Single */;
    [SerializeField] public float m_DelayAfterHit /* System.Single */;
    [SerializeField] public float m_FadeInSpeed /* System.Single */;
    [SerializeField] public float m_FadeInDistance /* System.Single */;
    [SerializeField] public bool m_FadeOutEnabled /* System.Boolean */;
    [SerializeField] public float m_FadeOutSpeed /* System.Single */;
    [SerializeField] public float m_FadeOutDistance /* System.Single */;
    [SerializeField] public global::UnityEngine.AnimationClip m_FinishingAnimation /* UnityEngine.AnimationClip */;
    [SerializeField] public float m_UV0XSpeed /* System.Single */;
    [SerializeField] public bool m_ApplyFadeInSpeeedToUV0X /* System.Boolean */;
    [SerializeField] public float m_UV0XAlphaSpeedScale /* System.Single */;
}

}

