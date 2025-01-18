using System;
using UnityEngine;

namespace Kingmaker.Visual.Sound {

public class ParticleSystemEmitterTrigger : MonoBehaviour {
    [SerializeField] public object m_OnEmitActions /* Kingmaker.ElementsSystem.ActionsReference */;
    [SerializeField] public string m_EventOnEmit /* System.String */;
}

}

