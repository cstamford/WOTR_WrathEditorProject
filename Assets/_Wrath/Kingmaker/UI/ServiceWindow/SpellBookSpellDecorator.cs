using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.ServiceWindow {

public class SpellBookSpellDecorator : MonoBehaviour {
    [SerializeField] public object m_DecorationLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public ToggleGroup m_ColorToggleGroup /* UnityEngine.UI.ToggleGroup */;
    [SerializeField] public ToggleGroup m_BorderToggleGroup /* UnityEngine.UI.ToggleGroup */;
    public bool IsDefault /* System.Boolean */;
}

}

