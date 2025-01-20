using System;
using UnityEngine;

namespace Kingmaker.TurnBasedMode {

public class PathVisualizer : global::UnityEngine.MonoBehaviour {
    [SerializeField] public global::UnityEngine.LineRenderer m_MoveLineP /* UnityEngine.LineRenderer */;
    [SerializeField] public global::UnityEngine.MeshRenderer m_BreakMoveDecal /* UnityEngine.MeshRenderer */;
    [SerializeField] public global::UnityEngine.MeshRenderer m_BreakStandardDecal /* UnityEngine.MeshRenderer */;
    [SerializeField] public global::UnityEngine.Color m_WinterMoveColor /* UnityEngine.Color */;
    [SerializeField] public global::UnityEngine.Color m_WinterStandardColor /* UnityEngine.Color */;
    [SerializeField] public global::UnityEngine.Color m_WinterAoColor /* UnityEngine.Color */;
    [SerializeField] public global::UnityEngine.Color m_MoveColor /* UnityEngine.Color */;
    [SerializeField] public global::UnityEngine.Color m_StandardColor /* UnityEngine.Color */;
    [SerializeField] public global::UnityEngine.Color m_AoColor /* UnityEngine.Color */;
    [SerializeField] public float m_LineRendererResolution /* System.Single */;
    [SerializeField] public float m_LineVerticalOffset /* System.Single */;

    public enum PathElementType {
        FiveFootSegment = 0,
        MoveSegment = 1,
        StandardSegment = 2,
        AttackOfOpportunityPoint = 3,
        OutOfRangeSegment = 4,
        NonStopSegment = 5,
    }

}

}

