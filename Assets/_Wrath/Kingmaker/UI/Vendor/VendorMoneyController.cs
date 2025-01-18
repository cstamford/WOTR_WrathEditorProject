using Kingmaker.UI.Common;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.Vendor {

public class VendorMoneyController : MonoBehaviour {
    [SerializeField] public Image m_ToVendor /* UnityEngine.UI.Image */;
    [SerializeField] public Image m_ToPlayer /* UnityEngine.UI.Image */;
    [SerializeField] public object m_Count /* TMPro.TextMeshProUGUI */;
    [SerializeField] public UIAnimationPulse m_CountNotification /* Kingmaker.UI.Common.UIAnimationPulse */;
    [SerializeField] public Color m_ColorMinusPrice /* UnityEngine.Color */;
    [SerializeField] public Color m_ColorNormal /* UnityEngine.Color */;
}

}

