using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.Visual.Animation.Actions {

public class AnimationActionBase : global::UnityEngine.ScriptableObject {
    public float TransitionIn /* System.Single */;
    public float TransitionOut /* System.Single */;
    public object ExecutionMode /* Kingmaker.Visual.Animation.Actions.ExecutionMode */;
    public bool UseEmptyAvatarMask /* System.Boolean */;
    public global::System.Collections.Generic.List<global::UnityEngine.AvatarMask> AvatarMasks /* System.Collections.Generic.List<UnityEngine.AvatarMask> */;
}

}

