using Kingmaker.UI.GlobalMap;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.Globalmap.View {

public class GlobalMapView : MonoBehaviour {
    [SerializeField] public object m_Blueprint /* Kingmaker.Globalmap.Blueprints.Reference */;
    public object PlayerPawn /* Kingmaker.Globalmap.View.GlobalMapPlayerPawn */;
    public GlobalMapPawn WarCampPawn /* Kingmaker.Globalmap.View.GlobalMapPawn */;
    public GlobalMapPawn AzataIslandPawn /* Kingmaker.Globalmap.View.GlobalMapPawn */;
    public float AzataIslandPawnMovementJumpHeight /* System.Single */;
    public float AzataIslandPawnMovementTime /* System.Single */;
    public float AzataIslandPawnSpeedMax /* System.Single */;
    public int MaxRotationAngle /* System.Int32 */;
    public GlobalMapPathsVisual PathsVisual /* Kingmaker.UI.GlobalMap.GlobalMapPathsVisual */;
    public GameObject PawnsHolder /* UnityEngine.GameObject */;
    public GameObject MapPlane /* UnityEngine.GameObject */;
    public List<GameObject> AdditionalMapPlanes /* System.Collections.Generic.List<UnityEngine.GameObject> */;
    public bool HideEdges /* System.Boolean */;
    public bool HideNavigationArrows /* System.Boolean */;
    public Color HoverColor /* UnityEngine.Color */;
    public Color SelectColor /* UnityEngine.Color */;
    public Color CurretnColor /* UnityEngine.Color */;
    public object Drezen /* Kingmaker.Globalmap.Blueprints.Reference */;
}

}

