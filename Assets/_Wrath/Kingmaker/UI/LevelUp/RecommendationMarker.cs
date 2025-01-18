using Kingmaker.UI.Tooltip;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.LevelUp {

public class RecommendationMarker : MonoBehaviour {
    [SerializeField] public Sprite m_Recommended /* UnityEngine.Sprite */;
    [SerializeField] public Sprite m_NotRecommended /* UnityEngine.Sprite */;
    public Image Star /* UnityEngine.UI.Image */;
    [SerializeField] public TooltipTrigger m_Tooltip /* Kingmaker.UI.Tooltip.TooltipTrigger */;
    [SerializeField] public GameObject m_Place /* UnityEngine.GameObject */;
}

}

