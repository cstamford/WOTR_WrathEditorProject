using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.ServiceWindow.CharacterScreen {

public class CharSComponentAttack : global::UnityEngine.MonoBehaviour {
    public global::UnityEngine.GameObject IconSlot /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.UI.Image m_Icon /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.CanvasGroup m_IconAlpha /* UnityEngine.CanvasGroup */;
    [SerializeField] public global::UnityEngine.UI.Image m_IconPlaceholder /* UnityEngine.UI.Image */;
    public global::Kingmaker.UI.ServiceWindow.CharacterScreen.CharSItemSlot ItemSlot /* Kingmaker.UI.ServiceWindow.CharacterScreen.CharSItemSlot */;
    public global::UnityEngine.GameObject Attack /* UnityEngine.GameObject */;
    public global::System.Collections.Generic.List<global::Kingmaker.UI.ServiceWindow.CharacterScreen.CharSComponentSmallScoreString> AttackValues /* System.Collections.Generic.List<Kingmaker.UI.ServiceWindow.CharacterScreen.CharSComponentSmallScoreString> */;
    public global::UnityEngine.GameObject Damage /* UnityEngine.GameObject */;
    public global::Kingmaker.UI.ServiceWindow.CharacterScreen.CharSComponentSmallScoreString DamageValue /* Kingmaker.UI.ServiceWindow.CharacterScreen.CharSComponentSmallScoreString */;
    public global::UnityEngine.GameObject Crit /* UnityEngine.GameObject */;
    public global::Kingmaker.UI.ServiceWindow.CharacterScreen.CharSComponentSmallScoreString CritDamageValue /* Kingmaker.UI.ServiceWindow.CharacterScreen.CharSComponentSmallScoreString */;
    public global::Kingmaker.UI.ServiceWindow.CharacterScreen.CharSComponentSmallScoreString CritChanceValue /* Kingmaker.UI.ServiceWindow.CharacterScreen.CharSComponentSmallScoreString */;
    public global::UnityEngine.GameObject Range /* UnityEngine.GameObject */;
    public global::Kingmaker.UI.ServiceWindow.CharacterScreen.CharSComponentSmallScoreString RangeValue /* Kingmaker.UI.ServiceWindow.CharacterScreen.CharSComponentSmallScoreString */;
    public object MAIN /* TMPro.TextMeshProUGUI */;
    public object RANGE /* TMPro.TextMeshProUGUI */;
    public object HAND /* TMPro.TextMeshProUGUI */;
    public object ATTACK /* TMPro.TextMeshProUGUI */;
    public object DAMAGE /* TMPro.TextMeshProUGUI */;
    public object CRIT /* TMPro.TextMeshProUGUI */;
}

}

