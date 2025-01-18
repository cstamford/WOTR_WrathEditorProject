using System;
using UnityEngine;

namespace Kingmaker.Visual.Decals {

public class ScreenSpaceDecal : MonoBehaviour {
    [SerializeField] public Material m_Material /* UnityEngine.Material */;
    [SerializeField] public int m_Layer /* System.Int32 */;
    [SerializeField] public bool m_ValidateHeight /* System.Boolean */;
    [SerializeField] public LayerMask m_RaycastMask /* UnityEngine.LayerMask */;
}

}

