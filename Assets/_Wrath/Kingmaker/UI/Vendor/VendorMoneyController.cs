using Kingmaker.UI.Common;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.Vendor {

public class VendorMoneyController : global::UnityEngine.MonoBehaviour {
    [SerializeField] public global::UnityEngine.UI.Image m_ToVendor /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.UI.Image m_ToPlayer /* UnityEngine.UI.Image */;
    [SerializeField] public object m_Count /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.Common.UIAnimationPulse m_CountNotification /* Kingmaker.UI.Common.UIAnimationPulse */;
    [SerializeField] public global::UnityEngine.Color m_ColorMinusPrice /* UnityEngine.Color */;
    [SerializeField] public global::UnityEngine.Color m_ColorNormal /* UnityEngine.Color */;
}

}

