using System;
using UnityEngine;

namespace Kingmaker.View.MapObjects {

public class CampPlaceView : global::Kingmaker.View.MapObjects.MapObjectView {
    public bool PlacedByPlayer /* System.Boolean */;
    public float PlaceRadius /* System.Single */;
    public float CameraZoom /* System.Single */;
    public global::UnityEngine.GameObject UIMarkerPrefab /* UnityEngine.GameObject */;
    [SerializeField] public object m_InactiveCamp /* Kingmaker.Blueprints.BlueprintDynamicMapObjectReference */;
    public string PlaceSound /* System.String */;
    public global::UnityEngine.GameObject FireFx /* UnityEngine.GameObject */;
    public global::UnityEngine.GameObject CampSceneSound /* UnityEngine.GameObject */;
    public global::UnityEngine.GameObject Preparation /* UnityEngine.GameObject */;
    public global::UnityEngine.GameObject Prepared /* UnityEngine.GameObject */;
    public global::UnityEngine.GameObject Sleeping /* UnityEngine.GameObject */;
    public global::UnityEngine.GameObject DivineServiceSuccess /* UnityEngine.GameObject */;
    public global::UnityEngine.GameObject DivineServiceStandard /* UnityEngine.GameObject */;
    public global::UnityEngine.GameObject DivineServiceFail /* UnityEngine.GameObject */;
    public global::UnityEngine.GameObject ScrollScribingSuccess /* UnityEngine.GameObject */;
    public global::UnityEngine.GameObject ScrollScribingStandard /* UnityEngine.GameObject */;
    public global::UnityEngine.GameObject ScrollScribingFail /* UnityEngine.GameObject */;
    public global::UnityEngine.GameObject AlchemyCookingSuccess /* UnityEngine.GameObject */;
    public global::UnityEngine.GameObject AlchemyCookingStandard /* UnityEngine.GameObject */;
    public global::UnityEngine.GameObject AlchemyCookingFail /* UnityEngine.GameObject */;
    public global::UnityEngine.GameObject[] AlchemyCookingNoCriticalFails /* UnityEngine.GameObject[] */;
    public global::UnityEngine.GameObject StandardTent /* UnityEngine.GameObject */;
    public global::UnityEngine.GameObject DisguisedTent /* UnityEngine.GameObject */;
    public global::UnityEngine.GameObject DisguiseCriticalFail /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.GameObject m_CameraAnchorPc /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.GameObject m_CameraAnchorConsole /* UnityEngine.GameObject */;
    public global::Kingmaker.View.MapObjects.FinneanCampObject Finnean /* Kingmaker.View.MapObjects.FinneanCampObject */;
}

}

