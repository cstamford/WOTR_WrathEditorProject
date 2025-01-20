using System;
using UnityEngine;

namespace Kingmaker.Sound {

public class AudioTriggerableEvent {
    [SerializeField] public object m_Event /* Kingmaker.Sound.AkEventReference */;
    [SerializeField] public bool m_ActionMode /* System.Boolean */;
    [SerializeField] public bool m_SkipIfLoading /* System.Boolean */;
    [SerializeField] public object m_Action /* .AkActionOnEventType */;
    [SerializeField] public float m_TransitionDuration /* System.Single */;
    [SerializeField] public object m_CurveInterpolation /* .AkCurveInterpolation */;
}

}

