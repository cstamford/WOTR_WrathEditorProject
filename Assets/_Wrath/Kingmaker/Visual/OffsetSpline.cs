using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.Visual {

public class OffsetSpline : global::UnityEngine.MonoBehaviour {
    [SerializeField] public global::UnityEngine.Vector2[] m_RawPoints /* UnityEngine.Vector2[] */;
    [SerializeField] public global::UnityEngine.Vector2[] m_RawOffsetPoints /* UnityEngine.Vector2[] */;
    [SerializeField] public global::System.Collections.Generic.List<global::UnityEngine.Vector2> m_Points /* System.Collections.Generic.List<UnityEngine.Vector2> */;
    [SerializeField] public global::System.Collections.Generic.List<float> m_PointsTimes /* System.Collections.Generic.List<System.Single> */;
    public float Offset /* System.Single */;
    public float step /* System.Single */;
    public int MaxSubdivisions /* System.Int32 */;
    [SerializeField] public global::System.Collections.Generic.List<global::Kingmaker.Visual.OffsetSpline.Point> m_Line /* System.Collections.Generic.List<Kingmaker.Visual.Point> */;

    public class Point {
        public float SplineT /* System.Single */;
        public global::UnityEngine.Vector2 From /* UnityEngine.Vector2 */;
        public global::UnityEngine.Vector2 To /* UnityEngine.Vector2 */;
        public bool StillGrowing /* System.Boolean */;
    }

}

}

