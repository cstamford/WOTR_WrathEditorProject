using Kingmaker.UI.Ping;
using System;
using UnityEngine;
using UnityEngine.UI.Extensions;

namespace Kingmaker.UI.ActionBar {

public class ActionBarIndexSlot : global::Kingmaker.UI.ActionBar.ActionBarGroupSlot {
    public object HotKey /* TMPro.TextMeshProUGUI */;
    public global::UnityEngine.UI.Extensions.UICornerCut ForeIcon /* UnityEngine.UI.Extensions.UICornerCut */;
    public global::Kingmaker.UI.Ping.PingHighlighter Ping /* Kingmaker.UI.Ping.PingHighlighter */;
    public global::UnityEngine.GameObject HotKeyBackground /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.RectTransform m_TooltipAnchor /* UnityEngine.RectTransform */;
}

}

