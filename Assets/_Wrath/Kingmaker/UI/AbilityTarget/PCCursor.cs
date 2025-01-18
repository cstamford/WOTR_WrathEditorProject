using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.AbilityTarget {

public class PCCursor : MonoBehaviour {
    [SerializeField] public Image Icon /* UnityEngine.UI.Image */;
    [SerializeField] public Image Background /* UnityEngine.UI.Image */;
    [SerializeField] public GameObject IconMask /* UnityEngine.GameObject */;
    [SerializeField] public GameObject CursorTarget /* UnityEngine.GameObject */;
    [SerializeField] public GameObject CanTarget /* UnityEngine.GameObject */;
    [SerializeField] public GameObject OutOfRange /* UnityEngine.GameObject */;
    [SerializeField] public object Text /* TMPro.TextMeshProUGUI */;
    [SerializeField] public float IgnoreUnitsColidersZPosition /* System.Single */;
    [SerializeField] public object IgnoreUnitsColiders /* UniRx.BoolReactiveProperty */;
    [SerializeField] public CanvasScaler m_CanvasScaler /* UnityEngine.UI.CanvasScaler */;
}

}

