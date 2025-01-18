using System;
using UnityEngine;

namespace Kingmaker.View {

public class SwarmBehaviour : MonoBehaviour {
    public GameObject[] SwarmObjects /* UnityEngine.GameObject[] */;
    public bool OrientWhenMoving /* System.Boolean */;
    public float AttackAnimationTime /* System.Single */;
    public object DeathType /* Kingmaker.View.SwarmDeathType */;
    public object ElementDirection /* Kingmaker.View.SwarmElementDirection */;
    public float RagdollTime /* System.Single */;
    public Vector3 KickUpVector /* UnityEngine.Vector3 */;
    public Vector3 Torque /* UnityEngine.Vector3 */;
    public float ImpulseValue /* System.Single */;
    public float RandomImpulseMin /* System.Single */;
    public float RandomImpulseMax /* System.Single */;
}

}

