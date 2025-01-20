using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.Visual.CharacterSystem.Dismemberment {

public class UnitDismembermentManager : global::UnityEngine.MonoBehaviour {
    public int SetIndex /* System.Int32 */;
    public int DestroyedPieceIndex /* System.Int32 */;
    public global::System.Collections.Generic.List<global::Kingmaker.Visual.CharacterSystem.Dismemberment.UnitDismembermentManager.DismembermentSet> Sets /* System.Collections.Generic.List<Kingmaker.Visual.CharacterSystem.Dismemberment.DismembermentSet> */;
    public global::UnityEngine.GameObject visualEffectPrefab /* UnityEngine.GameObject */;
    public global::System.Collections.Generic.Dictionary<global::UnityEngine.GameObject, global::UnityEngine.GameObject> AdditionalEquipment /* System.Collections.Generic.Dictionary<UnityEngine.GameObject, UnityEngine.GameObject> */;

    public class DismembermentBone {
        public global::UnityEngine.Transform Transform /* UnityEngine.Transform */;
        public float SliceOffset /* System.Single */;
        public global::UnityEngine.Vector3 SliceOrientationEuler /* UnityEngine.Vector3 */;
    }

    public class DismembermentSet {
        public object Type /* Kingmaker.Visual.CharacterSystem.Dismemberment.DismembermentLimbsApartType */;
        public global::System.Collections.Generic.List<global::Kingmaker.Visual.CharacterSystem.Dismemberment.UnitDismembermentManager.DismembermentBone> SliceBones /* System.Collections.Generic.List<Kingmaker.Visual.CharacterSystem.Dismemberment.DismembermentBone> */;
        public object Prefab /* Kingmaker.ResourceLinks.PrefabLink */;
    }

}

}

