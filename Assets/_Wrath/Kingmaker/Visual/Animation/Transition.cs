using Kingmaker.Visual.Animation.Actions;
using System;
using UnityEngine;

namespace Kingmaker.Visual.Animation {

public class Transition : global::UnityEngine.ScriptableObject {
    public global::Kingmaker.Visual.Animation.Actions.AnimationActionBase FromAction /* Kingmaker.Visual.Animation.Actions.AnimationActionBase */;
    public global::UnityEngine.AnimationClip FromClip /* UnityEngine.AnimationClip */;
    public global::Kingmaker.Visual.Animation.Actions.AnimationActionBase ToAction /* Kingmaker.Visual.Animation.Actions.AnimationActionBase */;
    public global::UnityEngine.AnimationClip ToClip /* UnityEngine.AnimationClip */;
    public float Duration /* System.Single */;
}

}

