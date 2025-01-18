using UnityEngine;

namespace Kingmaker.UI.MapObjectOvertip {

public class MapObjectOvertipsManager : MonoBehaviour {
    [SerializeField] public object m_AreaTransitionGlobalPrefab /* Kingmaker.UI.MapObjectOvertip.AreaTransitionController */;
    [SerializeField] public object m_AreaTransitionLocalPrefab /* Kingmaker.UI.MapObjectOvertip.AreaTransitionController */;
    [SerializeField] public object m_InteractiveObjectPrefab /* Kingmaker.UI.MapObjectOvertip.InteractiveObjectOvertipController */;
}

}

