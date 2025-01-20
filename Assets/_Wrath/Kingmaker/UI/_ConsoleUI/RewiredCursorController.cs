using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Kingmaker.UI._ConsoleUI {

public class RewiredCursorController {
    [SerializeField] public global::UnityEngine.UI.Image m_AbilityImage /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.UI.Image m_CursorImage /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.GameObject m_IconMask /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.GameObject m_CursorTarget /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.GameObject m_CanTarget /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.GameObject m_OutOfRange /* UnityEngine.GameObject */;
    [SerializeField] public object m_Text /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.CanvasGroup m_CanvasGroup /* UnityEngine.CanvasGroup */;
    public object Mouse /* Rewired.Components.PlayerMouse */;
    public float DeadZone /* System.Single */;
    public float WaitTime /* System.Single */;
    public object IgnoreUnitsColiders /* UniRx.BoolReactiveProperty */;
    [SerializeField] public float IgnoreUnitsColidersZPosition /* System.Single */;
}

}

