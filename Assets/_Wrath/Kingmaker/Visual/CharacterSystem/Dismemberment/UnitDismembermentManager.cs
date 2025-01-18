using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.Visual.CharacterSystem.Dismemberment {

public class UnitDismembermentManager : MonoBehaviour {
    public int SetIndex /* System.Int32 */;
    public int DestroyedPieceIndex /* System.Int32 */;
    public List<UnitDismembermentManager.DismembermentSet> Sets /* System.Collections.Generic.List<Kingmaker.Visual.CharacterSystem.Dismemberment.DismembermentSet> */;
    public GameObject visualEffectPrefab /* UnityEngine.GameObject */;
    public Dictionary<GameObject, GameObject> AdditionalEquipment /* System.Collections.Generic.Dictionary<UnityEngine.GameObject, UnityEngine.GameObject> */;

    public class DismembermentBone {
        public Transform Transform /* UnityEngine.Transform */;
        public float SliceOffset /* System.Single */;
        public Vector3 SliceOrientationEuler /* UnityEngine.Vector3 */;
    }

    public class DismembermentSet {
        public object Type /* Kingmaker.Visual.CharacterSystem.Dismemberment.DismembermentLimbsApartType */;
        public List<UnitDismembermentManager.DismembermentBone> SliceBones /* System.Collections.Generic.List<Kingmaker.Visual.CharacterSystem.Dismemberment.DismembermentBone> */;
        public object Prefab /* Kingmaker.ResourceLinks.PrefabLink */;
    }

}

}

