using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.ServiceWindow.CharacterScreen {

public class CharSComponentAttack : MonoBehaviour {
    public GameObject IconSlot /* UnityEngine.GameObject */;
    [SerializeField] public Image m_Icon /* UnityEngine.UI.Image */;
    [SerializeField] public CanvasGroup m_IconAlpha /* UnityEngine.CanvasGroup */;
    [SerializeField] public Image m_IconPlaceholder /* UnityEngine.UI.Image */;
    public object ItemSlot /* Kingmaker.UI.ServiceWindow.CharacterScreen.CharSItemSlot */;
    public GameObject Attack /* UnityEngine.GameObject */;
    public List<CharSComponentSmallScoreString> AttackValues /* System.Collections.Generic.List<Kingmaker.UI.ServiceWindow.CharacterScreen.CharSComponentSmallScoreString> */;
    public GameObject Damage /* UnityEngine.GameObject */;
    public CharSComponentSmallScoreString DamageValue /* Kingmaker.UI.ServiceWindow.CharacterScreen.CharSComponentSmallScoreString */;
    public GameObject Crit /* UnityEngine.GameObject */;
    public CharSComponentSmallScoreString CritDamageValue /* Kingmaker.UI.ServiceWindow.CharacterScreen.CharSComponentSmallScoreString */;
    public CharSComponentSmallScoreString CritChanceValue /* Kingmaker.UI.ServiceWindow.CharacterScreen.CharSComponentSmallScoreString */;
    public GameObject Range /* UnityEngine.GameObject */;
    public CharSComponentSmallScoreString RangeValue /* Kingmaker.UI.ServiceWindow.CharacterScreen.CharSComponentSmallScoreString */;
    public object MAIN /* TMPro.TextMeshProUGUI */;
    public object RANGE /* TMPro.TextMeshProUGUI */;
    public object HAND /* TMPro.TextMeshProUGUI */;
    public object ATTACK /* TMPro.TextMeshProUGUI */;
    public object DAMAGE /* TMPro.TextMeshProUGUI */;
    public object CRIT /* TMPro.TextMeshProUGUI */;
}

}

