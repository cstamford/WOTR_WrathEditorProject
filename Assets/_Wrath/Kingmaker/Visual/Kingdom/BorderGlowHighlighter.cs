using System;
using UnityEngine;

namespace Kingmaker.Visual.Kingdom {

public class BorderGlowHighlighter : MonoBehaviour {
    public bool IsGlobalMap /* System.Boolean */;
    public RenderTexture ResultingMask /* UnityEngine.RenderTexture */;
    public Material AddSdfMaterial /* UnityEngine.Material */;
    public RenderTexture LinesDistanceField /* UnityEngine.RenderTexture */;
    public RenderTexture AnimationDistanceField /* UnityEngine.RenderTexture */;
    public Material AnimationSdfMaterial /* UnityEngine.Material */;
    public object ToHighlightR /* Kingmaker.Kingdom.RegionObject[] */;
    public object ToHighlightG /* Kingmaker.Kingdom.RegionObject[] */;
    public object ToHighlightB /* Kingmaker.Kingdom.RegionObject[] */;
    public object ToHighlightA /* Kingmaker.Kingdom.RegionObject[] */;
    public object BordersR /* Kingmaker.Kingdom.RegionObject[] */;
    public object BordersG /* Kingmaker.Kingdom.RegionObject[] */;
    public object BordersB /* Kingmaker.Kingdom.RegionObject[] */;
    public object BordersA /* Kingmaker.Kingdom.RegionObject[] */;
    public Material RegionHighlighter /* UnityEngine.Material */;
}

}

