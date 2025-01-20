using Kingmaker.UI.MVVM._PCView.CombatLog;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.UI.MVVM._ConsoleView.CombatLog {

public class CombatLogConsoleView {
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.CombatLog.CombatLogItemConsoleView m_LogItemView /* Kingmaker.UI.MVVM._ConsoleView.CombatLog.CombatLogItemConsoleView */;
    [SerializeField] public global::UnityEngine.GameObject m_PinBackground /* UnityEngine.GameObject */;
    [SerializeField] public object m_ChannelText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_MultiSelectableActiveState /* Owlcat.Runtime.UI.Controls.Selectable.OwlcatMultiSelectable */;
    [SerializeField] public global::System.Collections.Generic.List<float> m_YSizesList /* System.Collections.Generic.List<System.Single> */;
    [SerializeField] public object m_ChangeSizeHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_ModePinHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_ConsoleHintFilterPrev /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_ConsoleHintFilterNext /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_ConsoleHintClose /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_HintOpenCloseAction /* Owlcat.Runtime.UI.ConsoleTools.GamepadInput.RewiredActionType */;
    [SerializeField] public object m_HintOpenCloseEventType /* Rewired.InputActionEventType */;
    [SerializeField] public object m_ConsoleHintOpen /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
}

}

