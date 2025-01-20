using System;
using UnityEngine;

namespace UnityEngine.UI.Extensions {

public class UILineRenderer : global::UnityEngine.UI.Extensions.UIPrimitiveBase {
    [SerializeField] public global::UnityEngine.Rect m_UVRect /* UnityEngine.Rect */;
    [SerializeField] public global::UnityEngine.Vector2[] m_points /* UnityEngine.Vector2[] */;
    public float LineThickness /* System.Single */;
    public bool UseMargins /* System.Boolean */;
    public global::UnityEngine.Vector2 Margin /* UnityEngine.Vector2 */;
    public bool relativeSize /* System.Boolean */;
    public bool LineList /* System.Boolean */;
    public bool LineCaps /* System.Boolean */;
    public global::UnityEngine.UI.Extensions.UILineRenderer.JoinType LineJoins /* UnityEngine.UI.Extensions.JoinType */;
    public global::UnityEngine.UI.Extensions.UILineRenderer.BezierType BezierMode /* UnityEngine.UI.Extensions.BezierType */;
    public int BezierSegmentsPerCurve /* System.Int32 */;

    public enum JoinType {
        Bevel = 0,
        Miter = 1,
    }

    public enum BezierType {
        None = 0,
        Quick = 1,
        Basic = 2,
        Improved = 3,
    }

}

}

