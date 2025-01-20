using System;
using UnityEngine;

namespace Kingmaker.UI.Tooltip {

public class DescriptionBrickPrerequisite : global::Kingmaker.UI.Tooltip.DescriptionBrick {
    [SerializeField] public global::UnityEngine.Sprite m_DoneSprite /* UnityEngine.Sprite */;
    [SerializeField] public global::UnityEngine.Sprite m_RequiredSprite /* UnityEngine.Sprite */;
    [SerializeField] public global::UnityEngine.Color32 m_DoneBGColor /* UnityEngine.Color32 */;
    [SerializeField] public global::UnityEngine.Color32 m_RequiredBGColor /* UnityEngine.Color32 */;
    [SerializeField] public global::Kingmaker.UI.Tooltip.PrerequisiteOrEntry m_PrerequisiteEntryPrefab /* Kingmaker.UI.Tooltip.PrerequisiteOrEntry */;
    [SerializeField] public global::UnityEngine.Transform m_PrerequisiteEntriesContainer /* UnityEngine.Transform */;
}

}

