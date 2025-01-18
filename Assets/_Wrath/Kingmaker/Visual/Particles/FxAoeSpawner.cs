using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.Visual.Particles {

public class FxAoeSpawner : MonoBehaviour {
    public object Pattern /* Kingmaker.Visual.Particles.FxAoeSpawnPattern */;
    public float Radius /* System.Single */;
    public GameObject FxVisualPrefab /* UnityEngine.GameObject */;
    public GameObject LocatorsObject /* UnityEngine.GameObject */;
    public LayerMask RaycastMask /* UnityEngine.LayerMask */;
    public float RaycastUpDownShift /* System.Single */;
    public List<FxAoeSpawner.Entry> Entries /* System.Collections.Generic.List<Kingmaker.Visual.Particles.Entry> */;

    public class Entry {
        public GameObject Root /* UnityEngine.GameObject */;
        public float DelayFxVisualPrefab /* System.Single */;
        public GameObject FxVisualPrefabOverride /* UnityEngine.GameObject */;
        public GameObject LocatorsObjectOverride /* UnityEngine.GameObject */;
    }

}

}

