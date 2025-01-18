using Kingmaker.UI.Bark;
using UnityEngine;

namespace Kingmaker.UI.Overtip {

public class OvertipManager : MonoBehaviour {
    public object Overtip /* Kingmaker.UI.Overtip.OvertipController */;
    public object ObjectOvertip /* Kingmaker.UI.Overtip.OvertipObjectController */;
    [SerializeField] public object m_OvertipSpellHandlePrefab /* Kingmaker.UI.Overtip.OvertipSpellHandle */;
    public BarkManager NonUnitBarks /* Kingmaker.UI.Bark.BarkManager */;
    public Transform ObjectContainer /* UnityEngine.Transform */;
    public Transform NpcContainer /* UnityEngine.Transform */;
    public Transform EnemyContainer /* UnityEngine.Transform */;
    public Transform PartyContainer /* UnityEngine.Transform */;
}

}

