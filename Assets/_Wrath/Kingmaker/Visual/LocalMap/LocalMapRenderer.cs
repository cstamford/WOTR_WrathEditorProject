using System;
using UnityEngine;

namespace Kingmaker.Visual.LocalMap {

public class LocalMapRenderer : global::UnityEngine.MonoBehaviour {
    [SerializeField] public global::UnityEngine.GameObject m_DefaultLight /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.GameObject m_NightLight /* UnityEngine.GameObject */;
    public float ViewAngle /* System.Single */;
    public float ViewAngleNormal /* System.Single */;
    public float ViewAngleGlobal /* System.Single */;
}

}

