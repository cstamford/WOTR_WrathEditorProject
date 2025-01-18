using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.ServiceWindow.CharacterScreen {

public class CharSComponentAbilitySlot : MonoBehaviour {
    public Image Icon /* UnityEngine.UI.Image */;
    public CanvasGroup CanvasGroup /* UnityEngine.CanvasGroup */;
    public object Name /* TMPro.TextMeshProUGUI */;
    public object Description /* TMPro.TextMeshProUGUI */;
    public Image Rank /* UnityEngine.UI.Image */;
    public object RankText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_BlueprintFeature /* Kingmaker.Blueprints.BlueprintFeatureBaseReference */;
    public Image RoundBorder /* UnityEngine.UI.Image */;
    public Image SquareBorder /* UnityEngine.UI.Image */;
    [SerializeField] public object m_AcronimText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public Material m_MaskMaterial /* UnityEngine.Material */;
}

}

