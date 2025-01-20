using Kingmaker.UI.MVVM._PCView.Party;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._ConsoleView.Party {

public class PartyCardCharacterConsoleView {
    [SerializeField] public object m_NameText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Party.UnitHealthPartTextView m_HealthTextView /* Kingmaker.UI.MVVM._PCView.Party.UnitHealthPartTextView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Party.UnitPortraitPartView m_PortraitView /* Kingmaker.UI.MVVM._PCView.Party.UnitPortraitPartView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Party.UnitEncumbrancePartView m_EncumbrancePartView /* Kingmaker.UI.MVVM._PCView.Party.UnitEncumbrancePartView */;
    [SerializeField] public global::UnityEngine.GameObject m_LinkIcon /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.GameObject m_AiIcon /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.GameObject m_HoldIcon /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.GameObject m_StealthIcon /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.GameObject m_LevelUpIcon /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.GameObject m_MythicLevelUpIcon /* UnityEngine.GameObject */;
    [SerializeField] public object m_MythicVisualVariantView /* Kingmaker.UI.MVVM._VM.DLC5.MythicVisualVariantView[] */;
}

}

