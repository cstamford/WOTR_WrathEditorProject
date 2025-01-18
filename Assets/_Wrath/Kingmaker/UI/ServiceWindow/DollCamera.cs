using System;
using UnityEngine;

namespace Kingmaker.UI.ServiceWindow {

public class DollCamera : MonoBehaviour {
    [SerializeField] public float m_Elasticity /* System.Single */;
    [SerializeField] public float m_SensitivityZoom /* System.Single */;
    [SerializeField] public float m_SmoothZoom /* System.Single */;
    [SerializeField] public float m_MinZoom /* System.Single */;
    [SerializeField] public float m_MaxZoom /* System.Single */;
    [SerializeField] public object m_DefaultZoomPreset /* Kingmaker.UI.ServiceWindow.DollRoomCameraZoomPreset */;
    [SerializeField] public object m_CharacterZoomPreset /* Kingmaker.UI.ServiceWindow.DollRoomCameraZoomPreset */;
    [SerializeField] public Transform m_DefaultTargetTransform /* UnityEngine.Transform */;
}

}

