using System;
using UnityEngine;

namespace Kingmaker.View {

public class CameraZoom : global::UnityEngine.MonoBehaviour {
    [SerializeField] public global::UnityEngine.Camera m_Camera /* UnityEngine.Camera */;
    [SerializeField] public float m_ZoomLenght /* System.Single */;
    [SerializeField] public float m_Smooth /* System.Single */;
    [SerializeField] public float m_ScrollSpeed /* System.Single */;
    [SerializeField] public float FovMin /* System.Single */;
    [SerializeField] public float FovMax /* System.Single */;
    [SerializeField] public float FovGlobalMap /* System.Single */;
    [SerializeField] public float FovTacticalCombat /* System.Single */;
    [SerializeField] public float FovSettlement /* System.Single */;
}

}

