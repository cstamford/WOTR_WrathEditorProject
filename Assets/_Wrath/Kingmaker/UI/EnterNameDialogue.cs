using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI {

public class EnterNameDialogue : MonoBehaviour {
    [SerializeField] public Button m_OkButton /* UnityEngine.UI.Button */;
    [SerializeField] public Button m_CloseButton /* UnityEngine.UI.Button */;
    [SerializeField] public object m_Header /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_Hint /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_InputNameField /* TMPro.TMP_InputField */;
}

}

