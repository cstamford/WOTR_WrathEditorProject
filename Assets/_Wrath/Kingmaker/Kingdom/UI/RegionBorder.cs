using Kingmaker.Kingdom;
using System;
using UnityEngine;

namespace Kingmaker.Kingdom.UI {

public class RegionBorder : MonoBehaviour {
    public RegionObject LeftRegion /* Kingmaker.Kingdom.RegionObject */;
    public RegionObject RightRegion /* Kingmaker.Kingdom.RegionObject */;
    public LineRenderer Line /* UnityEngine.LineRenderer */;
    public LineRenderer LineFx00 /* UnityEngine.LineRenderer */;
    public LineRenderer LineFx01 /* UnityEngine.LineRenderer */;
    public LineRenderer LineFx02 /* UnityEngine.LineRenderer */;
    public LineRenderer LineFx03 /* UnityEngine.LineRenderer */;
    public LineRenderer ClaimBorder /* UnityEngine.LineRenderer */;
    public LineRenderer SelectionHighlightLineFx /* UnityEngine.LineRenderer */;
    public AnimationCurve Easing /* UnityEngine.AnimationCurve */;
    public Texture2D SdfTexture /* UnityEngine.Texture2D */;
    public float YBaseOffset /* System.Single */;
}

}

