using Kingmaker.UI.MVVM._PCView.Other;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.MVVM._PCView.CharGen.Phases.Spells {

public class CharGenSpellSelectorItemPCView {
    [SerializeField] public global::UnityEngine.UI.Image m_SpellIcon /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.Material m_GrayMaterial /* UnityEngine.Material */;
    [SerializeField] public object m_SpellName /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_SchoolName /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_Level /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Other.RecommendationMarkerPCView m_Marker /* Kingmaker.UI.MVVM._PCView.Other.RecommendationMarkerPCView */;
    [SerializeField] public int m_MaxSymbols /* System.Int32 */;
    [SerializeField] public object m_ConsoleFocusButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
}

}

