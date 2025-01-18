using Kingmaker.UI.Common.Animations;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.Kingdom {

public class KingdomPurchaseBuildPoint : MonoBehaviour {
    [SerializeField] public WindowAnimator m_WindowAnimator /* Kingmaker.UI.Common.Animations.WindowAnimator */;
    [SerializeField] public Button m_ConfrimButton /* UnityEngine.UI.Button */;
    [SerializeField] public Button m_DeclineButton /* UnityEngine.UI.Button */;
    [SerializeField] public object m_ItemName /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_TotalPriceLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_CurrentCountLabel /* TMPro.TMP_InputField */;
    [SerializeField] public Image m_Icon /* UnityEngine.UI.Image */;
    [SerializeField] public Button m_UpButton /* UnityEngine.UI.Button */;
    [SerializeField] public Button m_DownButton /* UnityEngine.UI.Button */;
}

}

