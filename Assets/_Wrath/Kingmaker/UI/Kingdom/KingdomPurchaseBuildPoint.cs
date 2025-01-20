using Kingmaker.UI.Common.Animations;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.Kingdom {

public class KingdomPurchaseBuildPoint : global::UnityEngine.MonoBehaviour {
    [SerializeField] public global::Kingmaker.UI.Common.Animations.WindowAnimator m_WindowAnimator /* Kingmaker.UI.Common.Animations.WindowAnimator */;
    [SerializeField] public global::UnityEngine.UI.Button m_ConfrimButton /* UnityEngine.UI.Button */;
    [SerializeField] public global::UnityEngine.UI.Button m_DeclineButton /* UnityEngine.UI.Button */;
    [SerializeField] public object m_ItemName /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_TotalPriceLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_CurrentCountLabel /* TMPro.TMP_InputField */;
    [SerializeField] public global::UnityEngine.UI.Image m_Icon /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.UI.Button m_UpButton /* UnityEngine.UI.Button */;
    [SerializeField] public global::UnityEngine.UI.Button m_DownButton /* UnityEngine.UI.Button */;
}

}

