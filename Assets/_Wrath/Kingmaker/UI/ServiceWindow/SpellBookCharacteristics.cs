using System;
using UnityEngine;

namespace Kingmaker.UI.ServiceWindow {

public class SpellBookCharacteristics : global::UnityEngine.MonoBehaviour {
    [SerializeField] public object m_Labels /* Kingmaker.UI.ServiceWindow.SpellBookCharacteristicsLabels */;
    public object CasterLevel /* TMPro.TextMeshProUGUI */;
    public object SpellPenetration /* TMPro.TextMeshProUGUI */;
    public object Concentration /* TMPro.TextMeshProUGUI */;
    public object SpellFailureChance /* TMPro.TextMeshProUGUI */;
    public global::UnityEngine.GameObject SpellFailureContainer /* UnityEngine.GameObject */;
}

}

