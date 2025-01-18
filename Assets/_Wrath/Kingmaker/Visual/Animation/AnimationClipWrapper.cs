using Kingmaker.Visual.Animation.Events;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.Visual.Animation {

public class AnimationClipWrapper : ScriptableObject {
    [SerializeField] public AnimationClip m_AnimationClip /* UnityEngine.AnimationClip */;
    [SerializeField] public AnimationClipWrapper m_MountedAlternativeAnimation /* Kingmaker.Visual.Animation.AnimationClipWrapper */;
    [SerializeField] public bool m_IsShouldHandIKFree /* System.Boolean */;
    [SerializeField] public List<AnimationClipEventTrack> m_EventTracks /* System.Collections.Generic.List<Kingmaker.Visual.Animation.Events.AnimationClipEventTrack> */;
}

}

