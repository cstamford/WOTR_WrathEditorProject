using Kingmaker.UI.GlobalMap;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.Globalmap {

public class GlobalMapUI : MonoBehaviour {
    public GlobalMapBarkManager BarkManager /* Kingmaker.UI.GlobalMap.GlobalMapBarkManager */;
    [SerializeField] public GameObject m_BtnContinue /* UnityEngine.GameObject */;
    [SerializeField] public GameObject m_BtnStop /* UnityEngine.GameObject */;
    public List<GameObject> UiDirectionMarkers /* System.Collections.Generic.List<UnityEngine.GameObject> */;
    public NavigationArrowsController CompassPrefab /* Kingmaker.UI.GlobalMap.NavigationArrowsController */;
    public Transform CompassContainer /* UnityEngine.Transform */;
}

}

