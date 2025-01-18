using System;
using UnityEngine;

public class AnimatorControllerSpeedMultiplyer : MonoBehaviour {
    [SerializeField] public Animator _animator /* UnityEngine.Animator */;
    public float AnimatorSpeedGlobalMultiplyer /* System.Single */;
    public float AnimatorSpeedMultiplyer /* System.Single */;
    public bool Reverse /* System.Boolean */;
    public Vector2 RandomSpeed /* UnityEngine.Vector2 */;
    public bool RandomReverse /* System.Boolean */;
    public bool RandomCycleOffset /* System.Boolean */;
    public bool RandomAnimation /* System.Boolean */;
    public float AnimatorDeelay /* System.Single */;
    public float RandomStart /* System.Single */;
    public bool GearsGizmo /* System.Boolean */;
}

