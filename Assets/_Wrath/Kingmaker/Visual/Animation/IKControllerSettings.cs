using System;
using UnityEngine;

namespace Kingmaker.Visual.Animation {

public class IKControllerSettings : ScriptableObject {
    public bool EnableIk /* System.Boolean */;
    public bool MoveRightTorch /* System.Boolean */;
    public Vector3 RightTorchTargetPosition /* UnityEngine.Vector3 */;
    public bool RotateRightTorch /* System.Boolean */;
    public Quaternion RightTorchTargetRotation /* UnityEngine.Quaternion */;
    public bool MoveLeftTorch /* System.Boolean */;
    public Vector3 LeftTorchTargetPosition /* UnityEngine.Vector3 */;
    public bool RotateLeftTorch /* System.Boolean */;
    public Quaternion LeftTorchTargetRotation /* UnityEngine.Quaternion */;
    public Vector3 ShieldTargetPosition /* UnityEngine.Vector3 */;
    public Quaternion ShieldTargetRotation /* UnityEngine.Quaternion */;
}

}

