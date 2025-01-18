using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.Group {

public class GroupCharacterPortraitController : MonoBehaviour {
    public Image Frame /* UnityEngine.UI.Image */;
    [SerializeField] public Sprite m_SelectionSprite /* UnityEngine.Sprite */;
    [SerializeField] public Sprite m_NormalSprite /* UnityEngine.Sprite */;
    public object HitPoints /* TMPro.TextMeshProUGUI */;
    public CanvasGroup HitPointsContainer /* UnityEngine.CanvasGroup */;
    public Image Portrait /* UnityEngine.UI.Image */;
    public Image LifePortrait /* UnityEngine.UI.Image */;
    public Image Cripple /* UnityEngine.UI.Image */;
    public object CrippleMark /* ._2dxFX_DesintegrationFX */;
    public bool NeedAnim /* System.Boolean */;
    public Color NormalHpColor /* UnityEngine.Color */;
    public Color DeathHpColor /* UnityEngine.Color */;
}

}

