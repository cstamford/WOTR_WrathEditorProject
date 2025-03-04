using System;
using UnityEngine;

public class PlayerPortraitTaker : global::UnityEngine.MonoBehaviour {
    [SerializeField] public global::UnityEngine.MeshRenderer m_MeshRenderer /* UnityEngine.MeshRenderer */;
    public int MatIndex /* System.Int32 */;
    [SerializeField] public object oilPaint /* Owlcat.Runtime.Visual.Effects.OilPaint */;
    public PlayerPortraitTaker.PortraitSize portraitSize /* .PortraitSize */;

    public enum PortraitSize {
        Small = 0,
        Half = 1,
        Full = 2,
    }

}

