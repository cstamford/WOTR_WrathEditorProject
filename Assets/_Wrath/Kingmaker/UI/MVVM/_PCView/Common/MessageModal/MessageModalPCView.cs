using Kingmaker.UI.MVVM._PCView.Slots;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.UI.MVVM._PCView.Common.MessageModal {

public class MessageModalPCView {
    [SerializeField] public object m_MessageText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public TMPLinkHandler m_LinkHandler /* .TMPLinkHandler */;
    [SerializeField] public object m_InputField /* TMPro.TMP_InputField */;
    [SerializeField] public object m_AcceptButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public object m_DeclineButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public object m_AcceptText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_DeclineText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Slots.BaseItemSlotPCView m_BaseItemSlotPCView /* Kingmaker.UI.MVVM._PCView.Slots.BaseItemSlotPCView */;
    [SerializeField] public global::UnityEngine.RectTransform m_ItemContainer /* UnityEngine.RectTransform */;
    [SerializeField] public global::UnityEngine.GameObject m_ItemBlock /* UnityEngine.GameObject */;
    [SerializeField] public global::System.Collections.Generic.List<global::Kingmaker.UI.MVVM._PCView.Slots.BaseItemSlotPCView> m_Items /* System.Collections.Generic.List<Kingmaker.UI.MVVM._PCView.Slots.BaseItemSlotPCView> */;
}

}

