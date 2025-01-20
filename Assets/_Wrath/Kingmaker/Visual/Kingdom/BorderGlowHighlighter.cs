using System;
using UnityEngine;

namespace Kingmaker.Visual.Kingdom {

public class BorderGlowHighlighter : global::UnityEngine.MonoBehaviour {
    public bool IsGlobalMap /* System.Boolean */;
    public global::UnityEngine.RenderTexture ResultingMask /* UnityEngine.RenderTexture */;
    public global::UnityEngine.Material AddSdfMaterial /* UnityEngine.Material */;
    public global::UnityEngine.RenderTexture LinesDistanceField /* UnityEngine.RenderTexture */;
    public global::UnityEngine.RenderTexture AnimationDistanceField /* UnityEngine.RenderTexture */;
    public global::UnityEngine.Material AnimationSdfMaterial /* UnityEngine.Material */;
    public object ToHighlightR /* Kingmaker.Kingdom.RegionObject[] */;
    public object ToHighlightG /* Kingmaker.Kingdom.RegionObject[] */;
    public object ToHighlightB /* Kingmaker.Kingdom.RegionObject[] */;
    public object ToHighlightA /* Kingmaker.Kingdom.RegionObject[] */;
    public object BordersR /* Kingmaker.Kingdom.RegionObject[] */;
    public object BordersG /* Kingmaker.Kingdom.RegionObject[] */;
    public object BordersB /* Kingmaker.Kingdom.RegionObject[] */;
    public object BordersA /* Kingmaker.Kingdom.RegionObject[] */;
    public global::UnityEngine.Material RegionHighlighter /* UnityEngine.Material */;
}

}

