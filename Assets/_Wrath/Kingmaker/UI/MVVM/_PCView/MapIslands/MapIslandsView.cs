using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.MVVM._PCView.MapIslands {

public class MapIslandsView {
    [SerializeField] public global::UnityEngine.UI.Image m_BackgroundImage /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.UI.Image m_FrameImage /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.UI.Image m_ForegroundImage /* UnityEngine.UI.Image */;
    [SerializeField] public global::System.Collections.Generic.List<global::UnityEngine.UI.Image> m_Decorations /* System.Collections.Generic.List<UnityEngine.UI.Image> */;
    [SerializeField] public global::UnityEngine.UI.Image m_ArrowsImage /* UnityEngine.UI.Image */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.MapIslands.MapIslandItemView m_IslandItemView /* Kingmaker.UI.MVVM._PCView.MapIslands.MapIslandItemView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.MapIslands.MapIslandItemView m_FinalIslandItemView /* Kingmaker.UI.MVVM._PCView.MapIslands.MapIslandItemView */;
    [SerializeField] public global::UnityEngine.Vector2 m_FinalIslandPos /* UnityEngine.Vector2 */;
    [SerializeField] public global::UnityEngine.Vector2 m_FinalIslandSize /* UnityEngine.Vector2 */;
    [SerializeField] public global::UnityEngine.RectTransform m_IslandsContainer /* UnityEngine.RectTransform */;
    [SerializeField] public global::UnityEngine.RectTransform m_PlayerMarker /* UnityEngine.RectTransform */;
}

}

