using RootMotion;
using System;
using UnityEngine;

namespace RootMotion.Demos {

public class SimpleLocomotion : MonoBehaviour {
    [SerializeField] public CameraController cameraController /* RootMotion.CameraController */;
    [SerializeField] public float accelerationTime /* System.Single */;
    [SerializeField] public float turnTime /* System.Single */;
    [SerializeField] public bool walkByDefault /* System.Boolean */;
    [SerializeField] public SimpleLocomotion.RotationMode rotationMode /* RootMotion.Demos.RotationMode */;
    [SerializeField] public float moveSpeed /* System.Single */;

    public enum RotationMode {
        Smooth = 0,
        Linear = 1,
    }

}

}

