using Kingmaker.UI.MVVM._PCView.Party;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.MVVM._PCView.GroupChanger {

public class GroupChangerCharacterPCView {
    [SerializeField] public object m_Button /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
    [SerializeField] public global::UnityEngine.GameObject m_Lock /* UnityEngine.GameObject */;
    [SerializeField] public object m_Remove /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public global::UnityEngine.GameObject m_LevelUp /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.GameObject m_Mythic /* UnityEngine.GameObject */;
    [SerializeField] public object m_MythicVisualVariant /* Kingmaker.UI.MVVM._VM.DLC5.MythicVisualVariantView[] */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Party.UnitHealthPartTextView m_HealthPartTextView /* Kingmaker.UI.MVVM._PCView.Party.UnitHealthPartTextView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Party.UnitHealthPartProgressView m_HealthPartProgressView /* Kingmaker.UI.MVVM._PCView.Party.UnitHealthPartProgressView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Party.UnitBuffPartPCView m_BuffPartView /* Kingmaker.UI.MVVM._PCView.Party.UnitBuffPartPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Party.UnitPortraitPartView m_PortraitPartView /* Kingmaker.UI.MVVM._PCView.Party.UnitPortraitPartView */;
    [SerializeField] public global::UnityEngine.GameObject m_EncumbranceIndicator /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.Color m_EncumbranceHeavyLoad /* UnityEngine.Color */;
    [SerializeField] public global::UnityEngine.Color m_EncumbranceOverload /* UnityEngine.Color */;
    [SerializeField] public global::UnityEngine.UI.Image m_PersonalEncumbranceIcon /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.UI.Image m_PartyEncumbranceIcon /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.GameObject m_PersonalEncumbranceObject /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.GameObject m_PartyEncumbranceObject /* UnityEngine.GameObject */;
}

}

