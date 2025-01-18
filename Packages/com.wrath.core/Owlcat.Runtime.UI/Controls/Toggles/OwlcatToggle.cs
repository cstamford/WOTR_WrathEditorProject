using System;
using UnityEngine;

namespace Owlcat.Runtime.UI.Controls.Toggles {

public class OwlcatToggle : MonoBehaviour {
    [SerializeField] public object m_MultiButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
    [SerializeField] public OwlcatToggleGroup m_ToggleGroup /* Owlcat.Runtime.UI.Controls.Toggles.OwlcatToggleGroup */;
    [SerializeField] public bool m_PrimaryIsOn /* System.Boolean */;
}

}

