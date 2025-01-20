using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.MVVM._ConsoleView.Kingdom.Events {

public class KingdomEventConsoleView {
    [SerializeField] public object m_EventName /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_Description /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.UI.Image m_TypeImage /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.GameObject m_IsNewObject /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.GameObject m_CantStartObject /* UnityEngine.GameObject */;
}

}

