using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.SaveLoadWindow {

public class SaveSlot {
    [SerializeField] public object m_NameInputField /* TMPro.TMP_InputField */;
    [SerializeField] public global::UnityEngine.UI.Button m_ButtonSaveLoad /* UnityEngine.UI.Button */;
    [SerializeField] public object m_LabelSaveLoad /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_LabelDlcRequired /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.UI.Button m_ButtonDelete /* UnityEngine.UI.Button */;
}

}

