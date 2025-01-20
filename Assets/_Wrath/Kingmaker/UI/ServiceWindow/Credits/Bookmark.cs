using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.ServiceWindow.Credits {

public class Bookmark : global::Kingmaker.UI.ServiceWindow.Credits.CreditElement {
    [SerializeField] public object m_MultiButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
    [SerializeField] public global::UnityEngine.UI.Image m_IconNormal /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.UI.Image m_IconSelected /* UnityEngine.UI.Image */;
    [SerializeField] public object m_Group /* Kingmaker.Blueprints.BlueprintCreditsGroupReference */;
}

}

