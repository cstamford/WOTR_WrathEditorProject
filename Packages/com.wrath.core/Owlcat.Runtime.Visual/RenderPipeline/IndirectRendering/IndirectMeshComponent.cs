using System.Collections.Generic;
using UnityEngine;

namespace Owlcat.Runtime.Visual.RenderPipeline.IndirectRendering {

public class IndirectMeshComponent : MonoBehaviour {
    [SerializeField] public Mesh m_Mesh /* UnityEngine.Mesh */;
    [SerializeField] public List<Material> m_Materials /* System.Collections.Generic.List<UnityEngine.Material> */;
    [SerializeField] public Vector2 m_ScaleRange /* UnityEngine.Vector2 */;
    [SerializeField] public Vector2 m_RotationRange /* UnityEngine.Vector2 */;
}

}

