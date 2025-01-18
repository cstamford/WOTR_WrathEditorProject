using System;
using UnityEngine;

namespace RootMotion {

public class CameraController : MonoBehaviour {
    public Transform target /* UnityEngine.Transform */;
    public Transform rotationSpace /* UnityEngine.Transform */;
    public CameraController.UpdateMode updateMode /* RootMotion.UpdateMode */;
    public bool lockCursor /* System.Boolean */;
    public bool smoothFollow /* System.Boolean */;
    public float followSpeed /* System.Single */;
    public float distance /* System.Single */;
    public float minDistance /* System.Single */;
    public float maxDistance /* System.Single */;
    public float zoomSpeed /* System.Single */;
    public float zoomSensitivity /* System.Single */;
    public float rotationSensitivity /* System.Single */;
    public float yMinLimit /* System.Single */;
    public float yMaxLimit /* System.Single */;
    public Vector3 offset /* UnityEngine.Vector3 */;
    public bool rotateAlways /* System.Boolean */;
    public bool rotateOnLeftButton /* System.Boolean */;
    public bool rotateOnRightButton /* System.Boolean */;
    public bool rotateOnMiddleButton /* System.Boolean */;

    public enum UpdateMode {
        Update = 0,
        FixedUpdate = 1,
        LateUpdate = 2,
    }

}

}

