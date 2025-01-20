using System;
using UnityEngine;

namespace Kingmaker.View {

public class AreaEnterPoint : global::UnityEngine.MonoBehaviour {
    [SerializeField] public object m_Blueprint /* Kingmaker.Blueprints.BlueprintAreaEnterPointReference */;
    public bool RotateCameraOnEnter /* System.Boolean */;
    public global::UnityEngine.Transform CameraRotationTransform /* UnityEngine.Transform */;
    public bool MoveCameraOnEnter /* System.Boolean */;
    public global::UnityEngine.Transform CameraPositionTransform /* UnityEngine.Transform */;
}

}

