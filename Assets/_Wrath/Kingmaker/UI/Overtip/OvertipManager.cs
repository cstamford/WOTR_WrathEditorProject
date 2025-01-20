using Kingmaker.UI.Bark;
using System;
using UnityEngine;

namespace Kingmaker.UI.Overtip {

public class OvertipManager : global::UnityEngine.MonoBehaviour {
    public global::Kingmaker.UI.Overtip.OvertipController Overtip /* Kingmaker.UI.Overtip.OvertipController */;
    public global::Kingmaker.UI.Overtip.OvertipObjectController ObjectOvertip /* Kingmaker.UI.Overtip.OvertipObjectController */;
    [SerializeField] public global::Kingmaker.UI.Overtip.OvertipSpellHandle m_OvertipSpellHandlePrefab /* Kingmaker.UI.Overtip.OvertipSpellHandle */;
    public global::Kingmaker.UI.Bark.BarkManager NonUnitBarks /* Kingmaker.UI.Bark.BarkManager */;
    public global::UnityEngine.Transform ObjectContainer /* UnityEngine.Transform */;
    public global::UnityEngine.Transform NpcContainer /* UnityEngine.Transform */;
    public global::UnityEngine.Transform EnemyContainer /* UnityEngine.Transform */;
    public global::UnityEngine.Transform PartyContainer /* UnityEngine.Transform */;
}

}

