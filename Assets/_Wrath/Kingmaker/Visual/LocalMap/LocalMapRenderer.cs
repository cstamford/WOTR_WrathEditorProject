using System;
using UnityEngine;

namespace Kingmaker.Visual.LocalMap {

public class LocalMapRenderer : MonoBehaviour {
    [SerializeField] public GameObject m_DefaultLight /* UnityEngine.GameObject */;
    [SerializeField] public GameObject m_NightLight /* UnityEngine.GameObject */;
    public float ViewAngle /* System.Single */;
    public float ViewAngleNormal /* System.Single */;
    public float ViewAngleGlobal /* System.Single */;
}

}

