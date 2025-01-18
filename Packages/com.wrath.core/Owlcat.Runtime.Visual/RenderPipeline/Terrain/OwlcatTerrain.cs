using UnityEngine;

namespace Owlcat.Runtime.Visual.RenderPipeline.Terrain {

public class OwlcatTerrain : MonoBehaviour {
    public OwlcatTerrain.TerrainSizes TerrainSize /* Owlcat.Runtime.Visual.RenderPipeline.Terrain.TerrainSizes */;
    [SerializeField] public Vector4[] m_LayerDataMasksScale /* UnityEngine.Vector4[] */;
    [SerializeField] public Vector4[] m_LayerDataUvMatrix /* UnityEngine.Vector4[] */;
    [SerializeField] public Vector4[] m_LayerDataParams /* UnityEngine.Vector4[] */;
    [SerializeField] public Texture2DArray m_Diffuse /* UnityEngine.Texture2DArray */;
    [SerializeField] public Texture2DArray m_Normal /* UnityEngine.Texture2DArray */;
    [SerializeField] public Texture2DArray m_Masks /* UnityEngine.Texture2DArray */;
    public OwlcatTerrain.Tex2DArrayResolution TexturesResolution /* Owlcat.Runtime.Visual.RenderPipeline.Terrain.Tex2DArrayResolution */;
    [SerializeField] public Texture2DArray m_SplatArray /* UnityEngine.Texture2DArray */;

    public enum TerrainSizes {
        Fine_6 = 0,
        Diminutive_12 = 1,
        Tiny_25 = 2,
        Small_50 = 3,
        Small_75 = 4,
        Medium_100 = 5,
        Medium_150 = 6,
        Large_200 = 7,
        Large_250 = 8,
        Large_300 = 9,
        Huge_350 = 10,
        Huge_400 = 11,
    }

    public enum Tex2DArrayResolution {
        x128 = 128,
        x256 = 256,
        x512 = 512,
        x1024 = 1024,
    }

}

}

