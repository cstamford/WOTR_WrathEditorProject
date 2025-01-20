using System;
using UnityEngine;

namespace UnityEngine.EventSystems {

public class GamePadInputModule {
    [SerializeField] public string m_HorizontalAxis /* System.String */;
    [SerializeField] public string m_VerticalAxis /* System.String */;
    [SerializeField] public string m_SubmitButton /* System.String */;
    [SerializeField] public string m_CancelButton /* System.String */;
    [SerializeField] public float m_InputActionsPerSecond /* System.Single */;
    [SerializeField] public float m_RepeatDelay /* System.Single */;
}

}

