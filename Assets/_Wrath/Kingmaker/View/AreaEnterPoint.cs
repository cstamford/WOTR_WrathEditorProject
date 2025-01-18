using System;
using UnityEngine;

namespace Kingmaker.View {

public class AreaEnterPoint : MonoBehaviour {
    [SerializeField] public object m_Blueprint /* Kingmaker.Blueprints.BlueprintAreaEnterPointReference */;
    public bool RotateCameraOnEnter /* System.Boolean */;
    public Transform CameraRotationTransform /* UnityEngine.Transform */;
    public bool MoveCameraOnEnter /* System.Boolean */;
    public Transform CameraPositionTransform /* UnityEngine.Transform */;
}

}

