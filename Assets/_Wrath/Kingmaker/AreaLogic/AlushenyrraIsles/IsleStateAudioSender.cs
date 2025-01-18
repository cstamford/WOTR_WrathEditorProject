using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.AreaLogic.AlushenyrraIsles {

public class IsleStateAudioSender : MonoBehaviour {
    [SerializeField] public Animator m_IsleAnimator /* UnityEngine.Animator */;
    [SerializeField] public List<IsleStateAudioSender.SoundState> m_States /* System.Collections.Generic.List<Kingmaker.AreaLogic.AlushenyrraIsles.SoundState> */;

    public class SoundState {
        public int AnimatorHash /* System.Int32 */;
        public string StateName /* System.String */;
        public object OnEnterWwiseEvent /* Kingmaker.Sound.AkEventReference */;
        public object OnExitWwiseEvent /* Kingmaker.Sound.AkEventReference */;
    }

}

}

