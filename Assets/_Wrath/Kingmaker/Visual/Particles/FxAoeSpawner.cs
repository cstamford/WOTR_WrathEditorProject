using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.Visual.Particles {

public class FxAoeSpawner : global::UnityEngine.MonoBehaviour {
    public object Pattern /* Kingmaker.Visual.Particles.FxAoeSpawnPattern */;
    public float Radius /* System.Single */;
    public global::UnityEngine.GameObject FxVisualPrefab /* UnityEngine.GameObject */;
    public global::UnityEngine.GameObject LocatorsObject /* UnityEngine.GameObject */;
    public global::UnityEngine.LayerMask RaycastMask /* UnityEngine.LayerMask */;
    public float RaycastUpDownShift /* System.Single */;
    public global::System.Collections.Generic.List<global::Kingmaker.Visual.Particles.FxAoeSpawner.Entry> Entries /* System.Collections.Generic.List<Kingmaker.Visual.Particles.Entry> */;

    public class Entry {
        public global::UnityEngine.GameObject Root /* UnityEngine.GameObject */;
        public float DelayFxVisualPrefab /* System.Single */;
        public global::UnityEngine.GameObject FxVisualPrefabOverride /* UnityEngine.GameObject */;
        public global::UnityEngine.GameObject LocatorsObjectOverride /* UnityEngine.GameObject */;
    }

}

}

