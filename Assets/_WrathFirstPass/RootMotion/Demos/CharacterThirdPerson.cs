using RootMotion;
using System;
using UnityEngine;

namespace RootMotion.Demos {

public class CharacterThirdPerson {
    public global::RootMotion.Demos.CharacterAnimationBase characterAnimation /* RootMotion.Demos.CharacterAnimationBase */;
    public global::RootMotion.Demos.UserControlThirdPerson userControl /* RootMotion.Demos.UserControlThirdPerson */;
    public global::RootMotion.CameraController cam /* RootMotion.CameraController */;
    public global::RootMotion.Demos.CharacterThirdPerson.MoveMode moveMode /* RootMotion.Demos.MoveMode */;
    public bool smoothPhysics /* System.Boolean */;
    public float smoothAccelerationTime /* System.Single */;
    public float linearAccelerationSpeed /* System.Single */;
    public float platformFriction /* System.Single */;
    public float groundStickyEffect /* System.Single */;
    public float maxVerticalVelocityOnGround /* System.Single */;
    public float velocityToGroundTangentWeight /* System.Single */;
    public bool lookInCameraDirection /* System.Boolean */;
    public float turnSpeed /* System.Single */;
    public float stationaryTurnSpeedMlp /* System.Single */;
    public float airSpeed /* System.Single */;
    public float airControl /* System.Single */;
    public float jumpPower /* System.Single */;
    public float jumpRepeatDelayTime /* System.Single */;
    [SerializeField] public global::UnityEngine.LayerMask wallRunLayers /* UnityEngine.LayerMask */;
    public float wallRunMaxLength /* System.Single */;
    public float wallRunMinMoveMag /* System.Single */;
    public float wallRunMinVelocityY /* System.Single */;
    public float wallRunRotationSpeed /* System.Single */;
    public float wallRunMaxRotationAngle /* System.Single */;
    public float wallRunWeightSpeed /* System.Single */;
    public float crouchCapsuleScaleMlp /* System.Single */;

    public enum MoveMode {
        Directional = 0,
        Strafe = 1,
    }

}

}

