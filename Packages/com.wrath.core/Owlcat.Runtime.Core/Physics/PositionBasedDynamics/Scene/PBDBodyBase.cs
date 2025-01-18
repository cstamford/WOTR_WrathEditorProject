using System;
using UnityEngine;

namespace Owlcat.Runtime.Core.Physics.PositionBasedDynamics.Scene {

public class PBDBodyBase : MonoBehaviour {
    [SerializeField] public bool m_IsStatic /* System.Boolean */;
    [SerializeField] public float m_Restitution /* System.Single */;
    [SerializeField] public float m_Friction /* System.Single */;
    [SerializeField] public float m_TeleportDistanceTreshold /* System.Single */;
    [SerializeField] public object m_LocalColliders /* System.Collections.Generic.List */;
    [SerializeField] public object m_Particles /* System.Collections.Generic.List */;
    [SerializeField] public object m_Constraints /* System.Collections.Generic.List */;
    [SerializeField] public object m_DisconnectedConstraintsOffsetCount /* System.Collections.Generic.List */;
    [SerializeField] public object m_BodyInitializationMode /* Owlcat.Runtime.Core.Physics.PositionBasedDynamics.Scene.BodyInitializationMode */;
}

}

