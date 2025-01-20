using System;
using UnityEngine;

namespace Kingmaker.UI._ConsoleUI.TurnBasedMode {

public class ActionViewElement : global::UnityEngine.MonoBehaviour {
    [SerializeField] public object m_CurrentState /* Kingmaker.TurnBasedMode.Controllers.ActionState */;
    [SerializeField] public object m_ViewElements /* System.Collections.Generic.List */;
}

}

