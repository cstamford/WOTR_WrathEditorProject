using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.MVVM._PCView.MapIslands {

public class MapIslandItemView {
    [SerializeField] public global::UnityEngine.UI.Image m_IslandImage /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.UI.Image m_HoverImage /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.UI.Image m_VisitedImage /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.UI.Image m_SkippedImage /* UnityEngine.UI.Image */;
    [SerializeField] public object m_IslandButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.MapIslands.MapIslandDifficultyView m_DifficultyView /* Kingmaker.UI.MVVM._PCView.MapIslands.MapIslandDifficultyView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.MapIslands.MapIslandRewardView m_RewardView /* Kingmaker.UI.MVVM._PCView.MapIslands.MapIslandRewardView */;
}

}

