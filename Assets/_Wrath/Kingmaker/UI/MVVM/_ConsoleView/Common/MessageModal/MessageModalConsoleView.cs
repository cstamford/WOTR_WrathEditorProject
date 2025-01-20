using Kingmaker.UI.MVVM._ConsoleView.Common.InputField;
using Kingmaker.UI.MVVM._ConsoleView.Slots;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.UI.MVVM._ConsoleView.Common.MessageModal {

public class MessageModalConsoleView {
    [SerializeField] public object m_MessageText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public TMPLinkHandler m_LinkHandler /* .TMPLinkHandler */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Common.InputField.ConsoleInputField m_InputField /* Kingmaker.UI.MVVM._ConsoleView.Common.InputField.ConsoleInputField */;
    [SerializeField] public object m_AcceptHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_DeclineHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_InputFieldHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Slots.BaseItemSlotConsoleView m_BaseItemSlotConsoleView /* Kingmaker.UI.MVVM._ConsoleView.Slots.BaseItemSlotConsoleView */;
    [SerializeField] public global::UnityEngine.RectTransform m_ItemContainer /* UnityEngine.RectTransform */;
    [SerializeField] public global::UnityEngine.GameObject m_ItemBlock /* UnityEngine.GameObject */;
    [SerializeField] public global::System.Collections.Generic.List<global::Kingmaker.UI.MVVM._ConsoleView.Slots.BaseItemSlotConsoleView> m_Items /* System.Collections.Generic.List<Kingmaker.UI.MVVM._ConsoleView.Slots.BaseItemSlotConsoleView> */;
}

}

