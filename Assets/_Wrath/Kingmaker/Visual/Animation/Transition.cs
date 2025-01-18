using Kingmaker.Visual.Animation.Actions;
using System;
using UnityEngine;

namespace Kingmaker.Visual.Animation {

public class Transition : ScriptableObject {
    public AnimationActionBase FromAction /* Kingmaker.Visual.Animation.Actions.AnimationActionBase */;
    public AnimationClip FromClip /* UnityEngine.AnimationClip */;
    public AnimationActionBase ToAction /* Kingmaker.Visual.Animation.Actions.AnimationActionBase */;
    public AnimationClip ToClip /* UnityEngine.AnimationClip */;
    public float Duration /* System.Single */;
}

}

