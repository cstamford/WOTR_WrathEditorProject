using System;
using System.Collections.Generic;
using UnityEngine;

namespace Owlcat.Runtime.Visual.RenderPipeline.IndirectRendering.Details {

public class DetailsMesh : MonoBehaviour {
    [SerializeField] public Mesh m_Mesh /* UnityEngine.Mesh */;
    [SerializeField] public List<Material> m_Materials /* System.Collections.Generic.List<UnityEngine.Material> */;
    [SerializeField] public DetailsData m_Data /* Owlcat.Runtime.Visual.RenderPipeline.IndirectRendering.Details.DetailsData */;
    [SerializeField] public Vector2 m_ScaleRange /* UnityEngine.Vector2 */;
    [SerializeField] public Vector2 m_RotationRange /* UnityEngine.Vector2 */;
    [SerializeField] public string m_Guid /* System.String */;
}

}

