using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._PCView.Common.InputField {

public class PCInputField : global::UnityEngine.MonoBehaviour {
    [SerializeField] public object m_InputButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public object m_EditLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_FieldResult /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_InputField /* TMPro.TMP_InputField */;
    [SerializeField] public object m_InputFieldWhenEmpty /* TMPro.TextMeshProUGUI */;
}

}

