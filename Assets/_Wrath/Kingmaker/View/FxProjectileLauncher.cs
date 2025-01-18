using System;
using UnityEngine;

namespace Kingmaker.View {

public class FxProjectileLauncher : MonoBehaviour {
    [SerializeField] public object Blueprint /* Kingmaker.Blueprints.BlueprintProjectileReference */;
    [SerializeField] public bool m_InvertUpDirectionForTrajectories /* System.Boolean */;
    [SerializeField] public Transform m_Start /* UnityEngine.Transform */;
    [SerializeField] public Transform m_End /* UnityEngine.Transform */;
    [SerializeField] public float m_Delay /* System.Single */;
    [SerializeField] public bool m_CompensationOnTurnMode /* System.Boolean */;
}

}

