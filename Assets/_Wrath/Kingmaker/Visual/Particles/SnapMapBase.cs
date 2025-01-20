using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.Visual.Particles {

public class SnapMapBase : global::UnityEngine.MonoBehaviour {
    [SerializeField] public float m_ParticleSizeScale /* System.Single */;
    [SerializeField] public float m_SizeScale /* System.Single */;
    [SerializeField] public float m_LifetimeScale /* System.Single */;
    [SerializeField] public float m_RateOverTimeScale /* System.Single */;
    [SerializeField] public float m_BurstScale /* System.Single */;
    public bool ShowGizmos /* System.Boolean */;
    public bool ResetLocatorsList /* System.Boolean */;
    public float ParticleSize /* System.Single */;
    public global::System.Collections.Generic.List<global::UnityEngine.GameObject> FxLocatorsObjects /* System.Collections.Generic.List<UnityEngine.GameObject> */;
    [SerializeField] public object m_Bones /* System.Collections.Generic.List */;
}

}

