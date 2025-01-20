using System;
using UnityEngine;

namespace Kingmaker.Visual.Animation {

public class IKControllerSettings : global::UnityEngine.ScriptableObject {
    public bool EnableIk /* System.Boolean */;
    public bool MoveRightTorch /* System.Boolean */;
    public global::UnityEngine.Vector3 RightTorchTargetPosition /* UnityEngine.Vector3 */;
    public bool RotateRightTorch /* System.Boolean */;
    public global::UnityEngine.Quaternion RightTorchTargetRotation /* UnityEngine.Quaternion */;
    public bool MoveLeftTorch /* System.Boolean */;
    public global::UnityEngine.Vector3 LeftTorchTargetPosition /* UnityEngine.Vector3 */;
    public bool RotateLeftTorch /* System.Boolean */;
    public global::UnityEngine.Quaternion LeftTorchTargetRotation /* UnityEngine.Quaternion */;
    public global::UnityEngine.Vector3 ShieldTargetPosition /* UnityEngine.Vector3 */;
    public global::UnityEngine.Quaternion ShieldTargetRotation /* UnityEngine.Quaternion */;
}

}

