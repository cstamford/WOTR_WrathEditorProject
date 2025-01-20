using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._PCView.Party {

public class PartyPCView {
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Party.PartyCharacterPCView m_CharacterPrefab /* Kingmaker.UI.MVVM._PCView.Party.PartyCharacterPCView */;
    [SerializeField] public object m_Next /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public object m_Prev /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public float m_HidePosY /* System.Single */;
    [SerializeField] public float m_ShowPosY /* System.Single */;
    [SerializeField] public global::UnityEngine.RectTransform m_Content /* UnityEngine.RectTransform */;
    [SerializeField] public float m_Shift /* System.Single */;
}

}

