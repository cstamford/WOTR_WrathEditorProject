using Kingmaker.UI.Common;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.MVVM._ConsoleView.DLCManager {

public class DLCEntityConsoleView {
    [SerializeField] public global::UnityEngine.UI.Image m_NewImage /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.UI.Image m_PurchasedImage /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.UI.Image m_KeyArtImage /* UnityEngine.UI.Image */;
    [SerializeField] public object m_TitleText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_NewText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_DescriptionText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.Common.ScrollRectExtended m_DescriptionScroll /* Kingmaker.UI.Common.ScrollRectExtended */;
    [SerializeField] public object m_BuyButtonText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_BuyButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public object m_DLCEnabledSelectable /* Owlcat.Runtime.UI.Controls.Selectable.OwlcatMultiSelectable */;
    [SerializeField] public object m_DLCNotAvailable /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.Material m_DLCNotAvailableKeyArtMaterial /* UnityEngine.Material */;
    [SerializeField] public object m_FocusButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
}

}

