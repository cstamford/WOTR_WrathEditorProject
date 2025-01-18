using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.UI.PointMarker {

public class PointMarkerController : MonoBehaviour {
    public Kingmaker.UI.PointMarker.PointMarker MarkerPrefab /* Kingmaker.UI.PointMarker.PointMarker */;
    public List<RectTransform> InfluencingContainers /* System.Collections.Generic.List<UnityEngine.RectTransform> */;
    [SerializeField] public object m_CanvasScaler /* Kingmaker.UI.CanvasScalerWorkaround */;
}

}

