using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._PCView.Party {

public class PartyCharacterPCView {
    public float BasePositionX /* System.Single */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Party.PartyCharacterPetPCView FirstPetPC /* Kingmaker.UI.MVVM._PCView.Party.PartyCharacterPetPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Party.PartyCharacterPetPCView SecondPetPC /* Kingmaker.UI.MVVM._PCView.Party.PartyCharacterPetPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Party.PartyCharacterPetPCView ThirdPetPC /* Kingmaker.UI.MVVM._PCView.Party.PartyCharacterPetPCView */;
    [SerializeField] public global::UnityEngine.GameObject UnpinPetGroup /* UnityEngine.GameObject */;
    [SerializeField] public object UnpinPetButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
}

}

