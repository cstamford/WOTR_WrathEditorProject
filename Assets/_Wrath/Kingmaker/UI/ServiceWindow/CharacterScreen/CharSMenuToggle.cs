using Kingmaker.UI.Tooltip;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.ServiceWindow.CharacterScreen {

public class CharSMenuToggle : MonoBehaviour {
    public Toggle Toggle /* UnityEngine.UI.Toggle */;
    [SerializeField] public object TitleNormal /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object TitleSelected /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_Controller /* Kingmaker.UI.ServiceWindow.CharacterScreen.CharacterScreenController */;
    [SerializeField] public int m_SectionNumber /* System.Int32 */;
    [SerializeField] public TooltipTrigger m_Tooltip /* Kingmaker.UI.Tooltip.TooltipTrigger */;
}

}

