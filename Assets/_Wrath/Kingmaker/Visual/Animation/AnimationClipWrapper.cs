using Kingmaker.Visual.Animation.Events;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.Visual.Animation {

public class AnimationClipWrapper : global::UnityEngine.ScriptableObject {
    [SerializeField] public global::UnityEngine.AnimationClip m_AnimationClip /* UnityEngine.AnimationClip */;
    [SerializeField] public global::Kingmaker.Visual.Animation.AnimationClipWrapper m_MountedAlternativeAnimation /* Kingmaker.Visual.Animation.AnimationClipWrapper */;
    [SerializeField] public bool m_IsShouldHandIKFree /* System.Boolean */;
    [SerializeField] public global::System.Collections.Generic.List<global::Kingmaker.Visual.Animation.Events.AnimationClipEventTrack> m_EventTracks /* System.Collections.Generic.List<Kingmaker.Visual.Animation.Events.AnimationClipEventTrack> */;
}

}

