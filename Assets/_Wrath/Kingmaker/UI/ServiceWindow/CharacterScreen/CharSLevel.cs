using Kingmaker.UI.Common;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.ServiceWindow.CharacterScreen {

public class CharSLevel : global::Kingmaker.UI.Common.UISection {
    public object EXPERIENCE /* TMPro.TextMeshProUGUI */;
    public object Level /* TMPro.TextMeshProUGUI */;
    public object ExpValue /* TMPro.TextMeshProUGUI */;
    public global::UnityEngine.UI.Slider ExpSlider /* UnityEngine.UI.Slider */;
    public global::UnityEngine.UI.Image NegativeLevel /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.GameObject m_LevelUpButton /* UnityEngine.GameObject */;
    [SerializeField] public object m_LevelUpButtonTitle /* TMPro.TextMeshProUGUI */;
}

}

