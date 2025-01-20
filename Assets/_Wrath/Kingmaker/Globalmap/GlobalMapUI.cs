using Kingmaker.UI.GlobalMap;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.Globalmap {

public class GlobalMapUI : global::UnityEngine.MonoBehaviour {
    public global::Kingmaker.UI.GlobalMap.GlobalMapBarkManager BarkManager /* Kingmaker.UI.GlobalMap.GlobalMapBarkManager */;
    [SerializeField] public global::UnityEngine.GameObject m_BtnContinue /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.GameObject m_BtnStop /* UnityEngine.GameObject */;
    public global::System.Collections.Generic.List<global::UnityEngine.GameObject> UiDirectionMarkers /* System.Collections.Generic.List<UnityEngine.GameObject> */;
    public global::Kingmaker.UI.GlobalMap.NavigationArrowsController CompassPrefab /* Kingmaker.UI.GlobalMap.NavigationArrowsController */;
    public global::UnityEngine.Transform CompassContainer /* UnityEngine.Transform */;
}

}

