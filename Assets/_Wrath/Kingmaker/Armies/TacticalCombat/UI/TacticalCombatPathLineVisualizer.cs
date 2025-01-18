using UnityEngine;

namespace Kingmaker.Armies.TacticalCombat.UI {

public class TacticalCombatPathLineVisualizer : MonoBehaviour {
    [SerializeField] public LineRenderer m_PathRenderer /* UnityEngine.LineRenderer */;
    [SerializeField] public LineRenderer m_PathOutOfRangeRenderer /* UnityEngine.LineRenderer */;
    [SerializeField] public GameObject m_ValidDestinationMark /* UnityEngine.GameObject */;
    [SerializeField] public GameObject m_InvalidDestinationMark /* UnityEngine.GameObject */;
}

}

