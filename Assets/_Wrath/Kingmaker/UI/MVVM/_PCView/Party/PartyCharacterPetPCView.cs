using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.MVVM._PCView.Party {

public class PartyCharacterPetPCView {
    [SerializeField] public object m_MainButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
    [SerializeField] public object m_PetName /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.UI.Image m_PetImage /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.UI.Image m_GrayscalePetImage /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.UI.Slider m_HpSlider /* UnityEngine.UI.Slider */;
    [SerializeField] public global::UnityEngine.UI.Image m_HpBackground /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.Color m_GreenColor /* UnityEngine.Color */;
    [SerializeField] public global::UnityEngine.Color m_YellowColor /* UnityEngine.Color */;
    [SerializeField] public global::UnityEngine.Color m_RedColor /* UnityEngine.Color */;
}

}

