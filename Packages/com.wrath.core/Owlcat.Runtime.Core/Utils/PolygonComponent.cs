using System;
using System.Collections.Generic;
using UnityEngine;

namespace Owlcat.Runtime.Core.Utils {

public class PolygonComponent : MonoBehaviour {
    [SerializeField] public List<Vector3> m_Points /* System.Collections.Generic.List<UnityEngine.Vector3> */;
    [SerializeField] public Color m_GizmoColor /* UnityEngine.Color */;
    [SerializeField] public bool m_Closed /* System.Boolean */;
    public float PointYShift /* System.Single */;
}

}

