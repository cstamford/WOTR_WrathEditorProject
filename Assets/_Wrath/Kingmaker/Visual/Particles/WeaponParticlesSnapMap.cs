using Kingmaker.Visual.Trails;
using System;
using UnityEngine;

namespace Kingmaker.Visual.Particles {

public class WeaponParticlesSnapMap {
    public global::Kingmaker.Visual.Particles.WeaponParticlesSnapMap.WeaponSlot Slot /* Kingmaker.Visual.Particles.WeaponSlot */;
    public global::UnityEngine.GameObject DefaultTrailPrefab /* UnityEngine.GameObject */;
    public global::UnityEngine.Gradient ColorGradient /* UnityEngine.Gradient */;
    public global::Kingmaker.Visual.Trails.CompositeTrailRenderer.TrailAlignment Alignment /* Kingmaker.Visual.Trails.TrailAlignment */;
    [SerializeField] public object m_TrailBones /* System.Collections.Generic.List */;

    public enum WeaponSlot {
        Unknown = -1,
        PrimaryHand = 0,
        SecondaryHand = 1,
        Additional1 = 2,
        Additional2 = 3,
        Additional3 = 4,
        Additional4 = 5,
        Additional5 = 6,
        Additional6 = 7,
        Additional7 = 8,
        Additional8 = 9,
    }

}

}

