using System;
using UnityEngine;

namespace Kingmaker.View {

public class UnitMovementAgentBase : MonoBehaviour {
    [SerializeField] public float m_Acceleration /* System.Single */;
    [SerializeField] public float m_MinSpeed /* System.Single */;
    [SerializeField] public float m_AngularSpeed /* System.Single */;
    [SerializeField] public float m_CombatAngularSpeed /* System.Single */;
    public bool ConnectedToObstacles /* System.Boolean */;
}

}

