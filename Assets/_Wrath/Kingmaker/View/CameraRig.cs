using System;
using UnityEngine;

namespace Kingmaker.View {

public class CameraRig : global::UnityEngine.MonoBehaviour {
    public bool NewBehaviour /* System.Boolean */;
    public bool NewBehaviour2 /* System.Boolean */;
    [SerializeField] public global::UnityEngine.Transform m_CameraAttachPoint /* UnityEngine.Transform */;
    [SerializeField] public global::UnityEngine.Transform m_CameraMapAttachPoint /* UnityEngine.Transform */;
    [SerializeField] public global::UnityEngine.Transform m_CameraTacticalCombatAttachPoint /* UnityEngine.Transform */;
    [SerializeField] public global::UnityEngine.Transform m_CameraSettlementAttachPoint /* UnityEngine.Transform */;
    [SerializeField] public global::UnityEngine.Transform m_CameraFreeAttachPoint /* UnityEngine.Transform */;
    [SerializeField] public global::UnityEngine.Transform m_CameraFreeSubAttachPoint /* UnityEngine.Transform */;
    [SerializeField] public global::UnityEngine.Transform m_AudioListener /* UnityEngine.Transform */;
    [SerializeField] public global::UnityEngine.GameObject m_MapLight /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.Bounds m_LevelBounds /* UnityEngine.Bounds */;
    [SerializeField] public float m_ScrollRubberBand /* System.Single */;
    [SerializeField] public float m_ScrollRubberBandCamp /* System.Single */;
    [SerializeField] public float m_ScrollScreenThreshold /* System.Single */;
    [SerializeField] public float m_ScrollSpeed /* System.Single */;
    [SerializeField] public float m_RotationSpeed /* System.Single */;
    [SerializeField] public float m_RotationTime /* System.Single */;
    [SerializeField] public float m_RotationRatio /* System.Single */;
    [SerializeField] public float m_ConsoleRotationSpeed /* System.Single */;
    public global::UnityEngine.Light CameraLight /* UnityEngine.Light */;
    public float TimeToGround /* System.Single */;
    public float DistanceFromHighGround /* System.Single */;
}

}

