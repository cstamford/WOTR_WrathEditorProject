using Kingmaker.UI.Tooltip;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.LevelUp {

public class RecommendationMarker : global::UnityEngine.MonoBehaviour {
    [SerializeField] public global::UnityEngine.Sprite m_Recommended /* UnityEngine.Sprite */;
    [SerializeField] public global::UnityEngine.Sprite m_NotRecommended /* UnityEngine.Sprite */;
    public global::UnityEngine.UI.Image Star /* UnityEngine.UI.Image */;
    [SerializeField] public global::Kingmaker.UI.Tooltip.TooltipTrigger m_Tooltip /* Kingmaker.UI.Tooltip.TooltipTrigger */;
    [SerializeField] public global::UnityEngine.GameObject m_Place /* UnityEngine.GameObject */;
}

}

