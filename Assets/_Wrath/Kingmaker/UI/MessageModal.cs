using Kingmaker.UI.Common;
using Kingmaker.UI.Common.Animations;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI {

public class MessageModal : MonoBehaviour {
    [SerializeField] public GameObject m_WindowContainer /* UnityEngine.GameObject */;
    [SerializeField] public WindowAnimator m_WindowAnimator /* Kingmaker.UI.Common.Animations.WindowAnimator */;
    [SerializeField] public GameObject m_Veil /* UnityEngine.GameObject */;
    [SerializeField] public Button m_ButtonYes /* UnityEngine.UI.Button */;
    [SerializeField] public object m_ButtonYesLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public Button m_ButtonNo /* UnityEngine.UI.Button */;
    [SerializeField] public object m_ButtonNoLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public Button m_ButtonOk /* UnityEngine.UI.Button */;
    [SerializeField] public object m_ButtonOkLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_Messagelabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public EditableTextInput m_InputField /* Kingmaker.UI.Common.EditableTextInput */;
}

}

