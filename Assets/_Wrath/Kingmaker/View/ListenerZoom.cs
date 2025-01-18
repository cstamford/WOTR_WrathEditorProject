using System;
using UnityEngine;

namespace Kingmaker.View {

public class ListenerZoom : MonoBehaviour {
    [SerializeField] public CameraZoom m_Input /* Kingmaker.View.CameraZoom */;
    [SerializeField] public Vector3 m_DirectionZoom /* UnityEngine.Vector3 */;
    [SerializeField] public float m_Min /* System.Single */;
    [SerializeField] public float m_Max /* System.Single */;
}

}

