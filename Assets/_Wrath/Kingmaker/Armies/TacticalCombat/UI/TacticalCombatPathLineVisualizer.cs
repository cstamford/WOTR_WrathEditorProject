using System;
using UnityEngine;

namespace Kingmaker.Armies.TacticalCombat.UI {

public class TacticalCombatPathLineVisualizer : global::UnityEngine.MonoBehaviour {
    [SerializeField] public global::UnityEngine.LineRenderer m_PathRenderer /* UnityEngine.LineRenderer */;
    [SerializeField] public global::UnityEngine.LineRenderer m_PathOutOfRangeRenderer /* UnityEngine.LineRenderer */;
    [SerializeField] public global::UnityEngine.GameObject m_ValidDestinationMark /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.GameObject m_InvalidDestinationMark /* UnityEngine.GameObject */;
}

}

