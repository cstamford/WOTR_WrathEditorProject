using Kingmaker.UI.Tooltip;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.ServiceWindow.CharacterScreen {

public class CharSScoreEntry : MonoBehaviour {
    public object Type /* Kingmaker.EntitySystem.Stats.StatType */;
    public object ShortName /* TMPro.TextMeshProUGUI */;
    public object LongName /* TMPro.TextMeshProUGUI */;
    public object Value /* TMPro.TextMeshProUGUI */;
    public object RaceBonus /* TMPro.TextMeshProUGUI */;
    public object Modifier /* TMPro.TextMeshProUGUI */;
    public Image Background /* UnityEngine.UI.Image */;
    public Image BackgroundModifier /* UnityEngine.UI.Image */;
    [SerializeField] public TooltipTrigger m_Tooltip /* Kingmaker.UI.Tooltip.TooltipTrigger */;
}

}

