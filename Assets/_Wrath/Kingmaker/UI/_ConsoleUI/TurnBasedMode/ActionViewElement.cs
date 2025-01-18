using UnityEngine;

namespace Kingmaker.UI._ConsoleUI.TurnBasedMode {

public class ActionViewElement : MonoBehaviour {
    [SerializeField] public object m_CurrentState /* Kingmaker.TurnBasedMode.Controllers.ActionState */;
    [SerializeField] public object m_ViewElements /* System.Collections.Generic.List */;
}

}

