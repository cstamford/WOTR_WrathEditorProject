using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.ServiceWindow {

public class SpellBookSpellDecorator : global::UnityEngine.MonoBehaviour {
    [SerializeField] public object m_DecorationLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.UI.ToggleGroup m_ColorToggleGroup /* UnityEngine.UI.ToggleGroup */;
    [SerializeField] public global::UnityEngine.UI.ToggleGroup m_BorderToggleGroup /* UnityEngine.UI.ToggleGroup */;
    public bool IsDefault /* System.Boolean */;
}

}

