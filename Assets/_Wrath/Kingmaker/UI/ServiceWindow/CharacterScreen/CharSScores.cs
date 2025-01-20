using Kingmaker.UI.Common;
using Kingmaker.UI.Tooltip;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.ServiceWindow.CharacterScreen {

public class CharSScores : global::Kingmaker.UI.Common.UISection {
    public object Alignment /* TMPro.TextMeshProUGUI */;
    public object Race /* TMPro.TextMeshProUGUI */;
    public global::UnityEngine.UI.Image Sex /* UnityEngine.UI.Image */;
    public global::Kingmaker.UI.Tooltip.TooltipTrigger RaceTooltip /* Kingmaker.UI.Tooltip.TooltipTrigger */;
    public global::UnityEngine.Sprite ManSprite /* UnityEngine.Sprite */;
    public global::UnityEngine.Sprite WomanSprite /* UnityEngine.Sprite */;
    public global::UnityEngine.GameObject ClassBox /* UnityEngine.GameObject */;
    public global::Kingmaker.UI.ServiceWindow.CharacterScreen.CharSComponentClassString ClassEntry /* Kingmaker.UI.ServiceWindow.CharacterScreen.CharSComponentClassString */;
    [SerializeField] public global::UnityEngine.Transform m_StatsContainer /* UnityEngine.Transform */;
    public object HP /* TMPro.TextMeshProUGUI */;
    public bool showRaceTraits /* System.Boolean */;
    public object Size /* TMPro.TextMeshProUGUI */;
    public object Speed /* TMPro.TextMeshProUGUI */;
    public object Vision /* TMPro.TextMeshProUGUI */;
    public object Labels /* Kingmaker.UI.ServiceWindow.CharacterScreen.CharSScoresLabels */;
    public global::System.Collections.Generic.List<global::Kingmaker.UI.ServiceWindow.CharacterScreen.CharSScoreEntry> StatEntries /* System.Collections.Generic.List<Kingmaker.UI.ServiceWindow.CharacterScreen.CharSScoreEntry> */;
}

}

