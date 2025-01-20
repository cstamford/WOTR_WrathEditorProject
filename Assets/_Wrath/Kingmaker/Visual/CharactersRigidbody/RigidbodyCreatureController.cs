using Kingmaker.View;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.Visual.CharactersRigidbody {

public class RigidbodyCreatureController : global::UnityEngine.MonoBehaviour {
    public bool RagdollOnlyOnDeath /* System.Boolean */;
    public global::UnityEngine.GameObject RootBone /* UnityEngine.GameObject */;
    public global::System.Collections.Generic.List<global::Kingmaker.Visual.CharactersRigidbody.RigidbodyCreatureController.BoneImpulseMultiplier> BoneImpulseMultipliers /* System.Collections.Generic.List<Kingmaker.Visual.CharactersRigidbody.BoneImpulseMultiplier> */;
    public bool RandomNegativeValueOnMultiplier /* System.Boolean */;
    public float BaseImpulseValue /* System.Single */;
    public float AdditionalImpulseMin /* System.Single */;
    public float AdditionalImpulseMax /* System.Single */;
    public float MultiplyVectorYAxis /* System.Single */;
    public float InProneMultiplier /* System.Single */;
    public float ImpulseValueMultiplierToParents /* System.Single */;
    public float ImpulseValueMultiplierToChildren /* System.Single */;
    public bool ApplyImpulseToAllBones /* System.Boolean */;
    public global::System.Collections.Generic.List<global::UnityEngine.Rigidbody> RigidBones /* System.Collections.Generic.List<UnityEngine.Rigidbody> */;
    public float RagdollTime /* System.Single */;
    public global::UnityEngine.GameObject weaponBone /* UnityEngine.GameObject */;
    public bool CheckForEarlyStopRagdoll /* System.Boolean */;
    public float MinRootPosition /* System.Single */;
    public float MinAllPosition /* System.Single */;
    public float MinTimeToStop /* System.Single */;
    public global::System.Collections.Generic.List<global::UnityEngine.Transform> BonesToReturn /* System.Collections.Generic.List<UnityEngine.Transform> */;
    public global::Kingmaker.View.UnitEntityView EntityView /* Kingmaker.View.UnitEntityView */;
    public object RagdollCurrentPositions /* System.Collections.Generic.List */;
    public bool PostEventWithSurface /* System.Boolean */;
    public global::System.Collections.Generic.List<global::Kingmaker.Visual.CharactersRigidbody.RagdollPostEventWithSurface> EventTargets /* System.Collections.Generic.List<Kingmaker.Visual.CharactersRigidbody.RagdollPostEventWithSurface> */;

    public struct BoneImpulseMultiplier {
        public global::UnityEngine.Rigidbody bone /* UnityEngine.Rigidbody */;
        public float multiplier /* System.Single */;
    }

}

}

