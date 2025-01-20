using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.SaveLoadWindow {

public class SaveInjectorView : global::UnityEngine.MonoBehaviour {
    [SerializeField] public object m_Header /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_Hint /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.UI.Button m_CloseBtn /* UnityEngine.UI.Button */;
    [SerializeField] public global::UnityEngine.UI.Button m_AcceptBtn /* UnityEngine.UI.Button */;
    [SerializeField] public global::Kingmaker.UI.SaveLoadWindow.ListOfSaves m_ListOfSaves /* Kingmaker.UI.SaveLoadWindow.ListOfSaves */;
}

}

