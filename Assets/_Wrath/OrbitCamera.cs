using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class OrbitCamera : global::UnityEngine.MonoBehaviour {
    public global::UnityEngine.Transform target /* UnityEngine.Transform */;
    public global::UnityEngine.Vector3 targetOffset /* UnityEngine.Vector3 */;
    public float distance /* System.Single */;
    public float maxDistance /* System.Single */;
    public float minDistance /* System.Single */;
    public float xSpeed /* System.Single */;
    public float ySpeed /* System.Single */;
    public int yMinLimit /* System.Int32 */;
    public int yMaxLimit /* System.Int32 */;
    public int zoomRate /* System.Int32 */;
    public float panSpeed /* System.Single */;
    public float zoomDampening /* System.Single */;
    public global::UnityEngine.UI.GraphicRaycaster m_Raycaster /* UnityEngine.UI.GraphicRaycaster */;
    public global::UnityEngine.EventSystems.PointerEventData m_PointerEventData /* UnityEngine.EventSystems.PointerEventData */;
    public global::UnityEngine.EventSystems.EventSystem m_EventSystem /* UnityEngine.EventSystems.EventSystem */;
}

