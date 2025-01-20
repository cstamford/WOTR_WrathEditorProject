using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.AbilityTarget {

public class PCCursor : global::UnityEngine.MonoBehaviour {
    [SerializeField] public global::UnityEngine.UI.Image Icon /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.UI.Image Background /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.GameObject IconMask /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.GameObject CursorTarget /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.GameObject CanTarget /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.GameObject OutOfRange /* UnityEngine.GameObject */;
    [SerializeField] public object Text /* TMPro.TextMeshProUGUI */;
    [SerializeField] public float IgnoreUnitsColidersZPosition /* System.Single */;
    [SerializeField] public object IgnoreUnitsColiders /* UniRx.BoolReactiveProperty */;
    [SerializeField] public global::UnityEngine.UI.CanvasScaler m_CanvasScaler /* UnityEngine.UI.CanvasScaler */;
}

}

