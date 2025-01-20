using Kingmaker.UI.Common;
using Kingmaker.UI.Common.Animations;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI {

public class MessageModal : global::UnityEngine.MonoBehaviour {
    [SerializeField] public global::UnityEngine.GameObject m_WindowContainer /* UnityEngine.GameObject */;
    [SerializeField] public global::Kingmaker.UI.Common.Animations.WindowAnimator m_WindowAnimator /* Kingmaker.UI.Common.Animations.WindowAnimator */;
    [SerializeField] public global::UnityEngine.GameObject m_Veil /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.UI.Button m_ButtonYes /* UnityEngine.UI.Button */;
    [SerializeField] public object m_ButtonYesLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.UI.Button m_ButtonNo /* UnityEngine.UI.Button */;
    [SerializeField] public object m_ButtonNoLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.UI.Button m_ButtonOk /* UnityEngine.UI.Button */;
    [SerializeField] public object m_ButtonOkLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_Messagelabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.Common.EditableTextInput m_InputField /* Kingmaker.UI.Common.EditableTextInput */;
}

}

