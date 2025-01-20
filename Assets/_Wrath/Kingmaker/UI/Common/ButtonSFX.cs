using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.Common {

public class ButtonSFX : global::UnityEngine.MonoBehaviour {
    [SerializeField] public global::UnityEngine.UI.Button m_Button /* UnityEngine.UI.Button */;
    [SerializeField] public object m_Click /* Kingmaker.UI.UISoundType */;
    [SerializeField] public object m_BlockClick /* Kingmaker.UI.UISoundType */;
    [SerializeField] public object m_Enter /* Kingmaker.UI.UISoundType */;
    [SerializeField] public object m_Exit /* Kingmaker.UI.UISoundType */;
}

}

