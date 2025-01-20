using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.Group {

public class GroupCharacterPortraitController : global::UnityEngine.MonoBehaviour {
    public global::UnityEngine.UI.Image Frame /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.Sprite m_SelectionSprite /* UnityEngine.Sprite */;
    [SerializeField] public global::UnityEngine.Sprite m_NormalSprite /* UnityEngine.Sprite */;
    public object HitPoints /* TMPro.TextMeshProUGUI */;
    public global::UnityEngine.CanvasGroup HitPointsContainer /* UnityEngine.CanvasGroup */;
    public global::UnityEngine.UI.Image Portrait /* UnityEngine.UI.Image */;
    public global::UnityEngine.UI.Image LifePortrait /* UnityEngine.UI.Image */;
    public global::UnityEngine.UI.Image Cripple /* UnityEngine.UI.Image */;
    public _2dxFX_DesintegrationFX CrippleMark /* ._2dxFX_DesintegrationFX */;
    public bool NeedAnim /* System.Boolean */;
    public global::UnityEngine.Color NormalHpColor /* UnityEngine.Color */;
    public global::UnityEngine.Color DeathHpColor /* UnityEngine.Color */;
}

}

