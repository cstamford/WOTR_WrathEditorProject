using Kingmaker.UI.GlobalMap;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.Globalmap.View {

public class GlobalMapView : global::UnityEngine.MonoBehaviour {
    [SerializeField] public object m_Blueprint /* Kingmaker.Globalmap.Blueprints.Reference */;
    public global::Kingmaker.Globalmap.View.GlobalMapPlayerPawn PlayerPawn /* Kingmaker.Globalmap.View.GlobalMapPlayerPawn */;
    public global::Kingmaker.Globalmap.View.GlobalMapPawn WarCampPawn /* Kingmaker.Globalmap.View.GlobalMapPawn */;
    public global::Kingmaker.Globalmap.View.GlobalMapPawn AzataIslandPawn /* Kingmaker.Globalmap.View.GlobalMapPawn */;
    public float AzataIslandPawnMovementJumpHeight /* System.Single */;
    public float AzataIslandPawnMovementTime /* System.Single */;
    public float AzataIslandPawnSpeedMax /* System.Single */;
    public int MaxRotationAngle /* System.Int32 */;
    public global::Kingmaker.UI.GlobalMap.GlobalMapPathsVisual PathsVisual /* Kingmaker.UI.GlobalMap.GlobalMapPathsVisual */;
    public global::UnityEngine.GameObject PawnsHolder /* UnityEngine.GameObject */;
    public global::UnityEngine.GameObject MapPlane /* UnityEngine.GameObject */;
    public global::System.Collections.Generic.List<global::UnityEngine.GameObject> AdditionalMapPlanes /* System.Collections.Generic.List<UnityEngine.GameObject> */;
    public bool HideEdges /* System.Boolean */;
    public bool HideNavigationArrows /* System.Boolean */;
    public global::UnityEngine.Color HoverColor /* UnityEngine.Color */;
    public global::UnityEngine.Color SelectColor /* UnityEngine.Color */;
    public global::UnityEngine.Color CurretnColor /* UnityEngine.Color */;
    public object Drezen /* Kingmaker.Globalmap.Blueprints.Reference */;
}

}

