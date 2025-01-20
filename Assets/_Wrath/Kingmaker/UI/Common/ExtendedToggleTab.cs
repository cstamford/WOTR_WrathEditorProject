using Kingmaker.UI.Common.Animations;
using Kingmaker.UI.LevelUp;
using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Kingmaker.UI.Common {

public class ExtendedToggleTab : global::UnityEngine.MonoBehaviour {
    public global::UnityEngine.UI.Toggle Toggle /* UnityEngine.UI.Toggle */;
    public object Name /* TMPro.TextMeshProUGUI */;
    public global::Kingmaker.UI.LevelUp.CharBAttentionMark AttentionMark /* Kingmaker.UI.LevelUp.CharBAttentionMark */;
    [SerializeField] public global::UnityEngine.UI.Image m_Highlight /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.UI.Image m_Selected /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.Sprite m_HighlightCanUse /* UnityEngine.Sprite */;
    [SerializeField] public global::UnityEngine.Sprite m_SelectedCanUse /* UnityEngine.Sprite */;
    [SerializeField] public global::UnityEngine.Sprite m_HighlightCanNotUse /* UnityEngine.Sprite */;
    [SerializeField] public global::UnityEngine.Sprite m_SelectedCanNotUse /* UnityEngine.Sprite */;
    [SerializeField] public global::Kingmaker.UI.Common.Animations.MoveAnimator m_MoveAnimator /* Kingmaker.UI.Common.Animations.MoveAnimator */;
    public global::UnityEngine.Events.UnityAction Action /* UnityEngine.Events.UnityAction */;
    public int LevelIndex /* System.Int32 */;
}

}

