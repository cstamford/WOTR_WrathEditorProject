using System;
using UnityEngine;

public class AnimatedLight : MonoBehaviour {
    [SerializeField] public float m_Delay /* System.Single */;
    [SerializeField] public float m_Lifetime /* System.Single */;
    [SerializeField] public Gradient m_ColorOverLifetime /* UnityEngine.Gradient */;
    [SerializeField] public AnimationCurve m_RangeOverLifetime /* UnityEngine.AnimationCurve */;
    [SerializeField] public AnimationCurve m_MoveXOverLifetime /* UnityEngine.AnimationCurve */;
    [SerializeField] public AnimationCurve m_MoveYOverLifetime /* UnityEngine.AnimationCurve */;
    [SerializeField] public AnimationCurve m_MoveZOverLifetime /* UnityEngine.AnimationCurve */;
    [SerializeField] public float m_MoveMultiplier /* System.Single */;
    [SerializeField] public bool m_LoopAnimation /* System.Boolean */;
    [SerializeField] public bool m_MoveInWorldspace /* System.Boolean */;
    [SerializeField] public bool m_DestroyOnEnd /* System.Boolean */;
    [SerializeField] public Color m_Color /* UnityEngine.Color */;
    [SerializeField] public float m_Intensity /* System.Single */;
    [SerializeField] public float m_Range /* System.Single */;
}

