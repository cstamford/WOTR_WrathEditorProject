using Kingmaker.UI.Tooltip;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.ServiceWindow.CharacterScreen {

public class CharSMenuToggle : global::UnityEngine.MonoBehaviour {
    public global::UnityEngine.UI.Toggle Toggle /* UnityEngine.UI.Toggle */;
    [SerializeField] public object TitleNormal /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object TitleSelected /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.ServiceWindow.CharacterScreen.CharacterScreenController m_Controller /* Kingmaker.UI.ServiceWindow.CharacterScreen.CharacterScreenController */;
    [SerializeField] public int m_SectionNumber /* System.Int32 */;
    [SerializeField] public global::Kingmaker.UI.Tooltip.TooltipTrigger m_Tooltip /* Kingmaker.UI.Tooltip.TooltipTrigger */;
}

}

