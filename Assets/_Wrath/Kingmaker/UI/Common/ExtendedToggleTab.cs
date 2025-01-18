using Kingmaker.UI.Common.Animations;
using Kingmaker.UI.LevelUp;
using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Kingmaker.UI.Common {

public class ExtendedToggleTab : MonoBehaviour {
    public Toggle Toggle /* UnityEngine.UI.Toggle */;
    public object Name /* TMPro.TextMeshProUGUI */;
    public CharBAttentionMark AttentionMark /* Kingmaker.UI.LevelUp.CharBAttentionMark */;
    [SerializeField] public Image m_Highlight /* UnityEngine.UI.Image */;
    [SerializeField] public Image m_Selected /* UnityEngine.UI.Image */;
    [SerializeField] public Sprite m_HighlightCanUse /* UnityEngine.Sprite */;
    [SerializeField] public Sprite m_SelectedCanUse /* UnityEngine.Sprite */;
    [SerializeField] public Sprite m_HighlightCanNotUse /* UnityEngine.Sprite */;
    [SerializeField] public Sprite m_SelectedCanNotUse /* UnityEngine.Sprite */;
    [SerializeField] public MoveAnimator m_MoveAnimator /* Kingmaker.UI.Common.Animations.MoveAnimator */;
    public UnityAction Action /* UnityEngine.Events.UnityAction */;
    public int LevelIndex /* System.Int32 */;
}

}

