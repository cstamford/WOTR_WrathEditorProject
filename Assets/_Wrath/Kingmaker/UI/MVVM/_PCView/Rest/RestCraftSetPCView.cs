using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.MVVM._PCView.Rest {

public class RestCraftSetPCView {
    [SerializeField] public object m_KitName /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.UI.Image m_KitIcon /* UnityEngine.UI.Image */;
    [SerializeField] public object m_KitLevel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::System.Collections.Generic.List<global::Kingmaker.UI.MVVM._PCView.Rest.RestCraftRestrictionPCView> RestrictionViews /* System.Collections.Generic.List<Kingmaker.UI.MVVM._PCView.Rest.RestCraftRestrictionPCView> */;
}

}

