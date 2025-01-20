using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._PCView.Vendor {

public class VendorSlotView : global::Kingmaker.UI.MVVM._PCView.Vendor.VendorGenericSlotView {
    [SerializeField] public object m_DisplayNameText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_TypeText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_WeightText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_CostText /* TMPro.TextMeshProUGUI */;
}

}

