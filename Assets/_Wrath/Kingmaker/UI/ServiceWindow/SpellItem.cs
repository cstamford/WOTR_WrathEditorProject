using Kingmaker.UI.Common.Animations;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.ServiceWindow {

public class SpellItem : global::Kingmaker.UI.ServiceWindow.SpellItemBase {
    [SerializeField] public object m_SpellNameLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_SchoolNameLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_SpellLevel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.Sprite m_SlotBorderStandart /* UnityEngine.Sprite */;
    [SerializeField] public global::UnityEngine.Sprite m_SlotBorderDomain /* UnityEngine.Sprite */;
    [SerializeField] public global::UnityEngine.GameObject m_SpellLevelContainer /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.UI.Image m_SlotBckgBorder /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.UI.Image m_SlotBckgFill /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.GameObject m_MetamagicContainer /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.UI.Button m_DeleteButton /* UnityEngine.UI.Button */;
    [SerializeField] public global::Kingmaker.UI.Common.Animations.DestroyAnimator m_Animator /* Kingmaker.UI.Common.Animations.DestroyAnimator */;
    public global::UnityEngine.UI.Image DecorationBorder /* UnityEngine.UI.Image */;
}

}

