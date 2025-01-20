using System;
using UnityEngine;

namespace Kingmaker.Controllers.Dialog {

public class DebugDialogPlayer : global::UnityEngine.MonoBehaviour {
    [SerializeField] public object m_Dialog /* Kingmaker.Blueprints.BlueprintDialogReference */;
    [SerializeField] public object m_DefaultSpeaker /* Kingmaker.Blueprints.BlueprintUnitReference */;
    public global::UnityEngine.GameObject Players /* UnityEngine.GameObject */;
    public global::UnityEngine.GameObject Speakers /* UnityEngine.GameObject */;
    public global::UnityEngine.GameObject Garage /* UnityEngine.GameObject */;
}

}

