using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._ConsoleView.Common.InputField {

public class ConsoleInputField : MonoBehaviour {
    public uint MinTextLength /* System.UInt32 */;
    [SerializeField] public object m_Button /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
    [SerializeField] public object m_InputField /* TMPro.TMP_InputField */;
    [SerializeField] public GameObject m_EditGameObject /* UnityEngine.GameObject */;
}

}

