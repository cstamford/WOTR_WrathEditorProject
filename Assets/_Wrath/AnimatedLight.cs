using System;
using UnityEngine;

public class AnimatedLight : global::UnityEngine.MonoBehaviour {
    [SerializeField] public float m_Delay /* System.Single */;
    [SerializeField] public float m_Lifetime /* System.Single */;
    [SerializeField] public global::UnityEngine.Gradient m_ColorOverLifetime /* UnityEngine.Gradient */;
    [SerializeField] public global::UnityEngine.AnimationCurve m_RangeOverLifetime /* UnityEngine.AnimationCurve */;
    [SerializeField] public global::UnityEngine.AnimationCurve m_MoveXOverLifetime /* UnityEngine.AnimationCurve */;
    [SerializeField] public global::UnityEngine.AnimationCurve m_MoveYOverLifetime /* UnityEngine.AnimationCurve */;
    [SerializeField] public global::UnityEngine.AnimationCurve m_MoveZOverLifetime /* UnityEngine.AnimationCurve */;
    [SerializeField] public float m_MoveMultiplier /* System.Single */;
    [SerializeField] public bool m_LoopAnimation /* System.Boolean */;
    [SerializeField] public bool m_MoveInWorldspace /* System.Boolean */;
    [SerializeField] public bool m_DestroyOnEnd /* System.Boolean */;
    [SerializeField] public global::UnityEngine.Color m_Color /* UnityEngine.Color */;
    [SerializeField] public float m_Intensity /* System.Single */;
    [SerializeField] public float m_Range /* System.Single */;
}

