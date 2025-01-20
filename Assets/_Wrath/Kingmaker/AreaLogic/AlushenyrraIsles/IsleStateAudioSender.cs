using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.AreaLogic.AlushenyrraIsles {

public class IsleStateAudioSender : global::UnityEngine.MonoBehaviour {
    [SerializeField] public global::UnityEngine.Animator m_IsleAnimator /* UnityEngine.Animator */;
    [SerializeField] public global::System.Collections.Generic.List<global::Kingmaker.AreaLogic.AlushenyrraIsles.IsleStateAudioSender.SoundState> m_States /* System.Collections.Generic.List<Kingmaker.AreaLogic.AlushenyrraIsles.SoundState> */;

    public class SoundState {
        public int AnimatorHash /* System.Int32 */;
        public string StateName /* System.String */;
        public object OnEnterWwiseEvent /* Kingmaker.Sound.AkEventReference */;
        public object OnExitWwiseEvent /* Kingmaker.Sound.AkEventReference */;
    }

}

}

