using System;
using UnityEngine;

namespace Kingmaker.Sound {

public class AkAudioTriggerable : global::UnityEngine.MonoBehaviour {
    [SerializeField] public bool m_LogTriggers /* System.Boolean */;
    [SerializeField] public object m_Triggers /* Kingmaker.Sound.TriggerType */;
    [SerializeField] public bool m_TriggerOnce /* System.Boolean */;
}

}

