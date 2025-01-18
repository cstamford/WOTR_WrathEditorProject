using System;
using UnityEngine;

namespace Owlcat.Runtime.Core.Physics.PositionBasedDynamics {

public class PositionBasedDynamicsConfig : ScriptableObject {
    [SerializeField] public object m_DebugSettings /* Owlcat.Runtime.Core.Physics.PositionBasedDynamics.PositionBaseDynamicsDebugSettings */;
    public bool GPU /* System.Boolean */;
    public bool UseExperimentalFeatures /* System.Boolean */;
    public object UpdateFrequency /* Owlcat.Runtime.Core.Physics.PositionBasedDynamics.UpdateFrequency */;
    public object UpdateMode /* Owlcat.Runtime.Core.Physics.PositionBasedDynamics.UpdateMode */;
    public int SimulationIterations /* System.Int32 */;
    public int ConstraintIterations /* System.Int32 */;
    public float Decay /* System.Single */;
    [SerializeField] public object m_BroadphaseSettings /* Owlcat.Runtime.Core.Physics.PositionBasedDynamics.Collisions.Broadphase.BroadphaseSettings */;
}

}

