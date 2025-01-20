using Kingmaker.UI.Tooltip;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.ServiceWindow.CharacterScreen {

public class CharSScoreEntry : global::UnityEngine.MonoBehaviour {
    public object Type /* Kingmaker.EntitySystem.Stats.StatType */;
    public object ShortName /* TMPro.TextMeshProUGUI */;
    public object LongName /* TMPro.TextMeshProUGUI */;
    public object Value /* TMPro.TextMeshProUGUI */;
    public object RaceBonus /* TMPro.TextMeshProUGUI */;
    public object Modifier /* TMPro.TextMeshProUGUI */;
    public global::UnityEngine.UI.Image Background /* UnityEngine.UI.Image */;
    public global::UnityEngine.UI.Image BackgroundModifier /* UnityEngine.UI.Image */;
    [SerializeField] public global::Kingmaker.UI.Tooltip.TooltipTrigger m_Tooltip /* Kingmaker.UI.Tooltip.TooltipTrigger */;
}

}

