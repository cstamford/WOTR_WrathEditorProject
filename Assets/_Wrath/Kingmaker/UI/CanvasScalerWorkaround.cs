using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Kingmaker.UI {

public class CanvasScalerWorkaround {
    [SerializeField] public global::Kingmaker.UI.CanvasScalerWorkaround.ScaleMode m_UiScaleMode /* Kingmaker.UI.ScaleMode */;
    [SerializeField] public float m_ReferencePixelsPerUnit /* System.Single */;
    [SerializeField] public float m_ScaleFactor /* System.Single */;
    [SerializeField] public global::UnityEngine.Vector2 m_ReferenceResolution /* UnityEngine.Vector2 */;
    [SerializeField] public global::Kingmaker.UI.CanvasScalerWorkaround.ScreenMatchMode m_ScreenMatchMode /* Kingmaker.UI.ScreenMatchMode */;
    [SerializeField] public float m_MatchWidthOrHeight /* System.Single */;
    [SerializeField] public global::Kingmaker.UI.CanvasScalerWorkaround.Unit m_PhysicalUnit /* Kingmaker.UI.Unit */;
    [SerializeField] public float m_FallbackScreenDPI /* System.Single */;
    [SerializeField] public float m_DefaultSpriteDPI /* System.Single */;
    [SerializeField] public float m_DynamicPixelsPerUnit /* System.Single */;

    public enum ScaleMode {
        ConstantPixelSize = 0,
        ScaleWithScreenSize = 1,
        ConstantPhysicalSize = 2,
    }

    public enum ScreenMatchMode {
        MatchWidthOrHeight = 0,
        Expand = 1,
        Shrink = 2,
    }

    public enum Unit {
        Centimeters = 0,
        Millimeters = 1,
        Inches = 2,
        Points = 3,
        Picas = 4,
    }

}

}

