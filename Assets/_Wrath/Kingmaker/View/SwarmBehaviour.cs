using System;
using UnityEngine;

namespace Kingmaker.View {

public class SwarmBehaviour : global::UnityEngine.MonoBehaviour {
    public global::UnityEngine.GameObject[] SwarmObjects /* UnityEngine.GameObject[] */;
    public bool OrientWhenMoving /* System.Boolean */;
    public float AttackAnimationTime /* System.Single */;
    public object DeathType /* Kingmaker.View.SwarmDeathType */;
    public object ElementDirection /* Kingmaker.View.SwarmElementDirection */;
    public float RagdollTime /* System.Single */;
    public global::UnityEngine.Vector3 KickUpVector /* UnityEngine.Vector3 */;
    public global::UnityEngine.Vector3 Torque /* UnityEngine.Vector3 */;
    public float ImpulseValue /* System.Single */;
    public float RandomImpulseMin /* System.Single */;
    public float RandomImpulseMax /* System.Single */;
}

}

