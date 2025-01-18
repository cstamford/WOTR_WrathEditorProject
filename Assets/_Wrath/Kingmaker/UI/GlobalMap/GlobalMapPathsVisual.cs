using System;
using UnityEngine;

namespace Kingmaker.UI.GlobalMap {

public class GlobalMapPathsVisual : MonoBehaviour {
    public AnimationCurve Curve /* UnityEngine.AnimationCurve */;
    public int Density /* System.Int32 */;
    public int MinPoint /* System.Int32 */;
    public float FadeTime /* System.Single */;
    [SerializeField] public LineRenderer m_CurrentPath /* UnityEngine.LineRenderer */;
    [SerializeField] public LineRenderer m_PlannedKnown /* UnityEngine.LineRenderer */;
    [SerializeField] public float m_CurrentPathHeight /* System.Single */;
    [SerializeField] public float m_PlannedPathHeight /* System.Single */;
    [SerializeField] public GameObject m_DestinationMarker /* UnityEngine.GameObject */;
}

}

