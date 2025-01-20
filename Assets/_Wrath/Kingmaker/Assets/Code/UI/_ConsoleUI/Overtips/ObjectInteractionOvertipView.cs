using Kingmaker.UI._ConsoleUI.Overtips;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.Assets.Code.UI._ConsoleUI.Overtips {

public class ObjectInteractionOvertipView {
    public float TweenDuration /* System.Single */;
    [SerializeField] public global::Kingmaker.UI._ConsoleUI.Overtips.OvertipViewPartName m_OvertipViewPartName /* Kingmaker.UI._ConsoleUI.Overtips.OvertipViewPartName */;
    public global::UnityEngine.RectTransform SkillContainer /* UnityEngine.RectTransform */;
    public object DescriptionText /* TMPro.TextMeshProUGUI */;
    public object SkillcheckText /* TMPro.TextMeshProUGUI */;
    public global::UnityEngine.RectTransform KingdomAttentionBlock /* UnityEngine.RectTransform */;
    public global::UnityEngine.CanvasGroup DescriptionCanvas /* UnityEngine.CanvasGroup */;
    public global::UnityEngine.UI.Image MainImage /* UnityEngine.UI.Image */;
    public global::UnityEngine.UI.Image HighlightImage /* UnityEngine.UI.Image */;
    public global::UnityEngine.UI.Image ActiveImage /* UnityEngine.UI.Image */;
    public global::Kingmaker.Assets.Code.UI._ConsoleUI.Overtips.ObjectInteractionOvertipView.UIInteractionTypeSprites ActionSprites /* Kingmaker.Assets.Code.UI._ConsoleUI.Overtips.UIInteractionTypeSprites */;
    public global::Kingmaker.Assets.Code.UI._ConsoleUI.Overtips.ObjectInteractionOvertipView.UIInteractionTypeSprites MoveSprites /* Kingmaker.Assets.Code.UI._ConsoleUI.Overtips.UIInteractionTypeSprites */;
    public global::Kingmaker.Assets.Code.UI._ConsoleUI.Overtips.ObjectInteractionOvertipView.UIInteractionTypeSprites InfoSprites /* Kingmaker.Assets.Code.UI._ConsoleUI.Overtips.UIInteractionTypeSprites */;
    public global::Kingmaker.UI._ConsoleUI.Overtips.OvertipViewPartBark OvertipViewPartBarkPrefab /* Kingmaker.UI._ConsoleUI.Overtips.OvertipViewPartBark */;
    [SerializeField] public float m_OvertipPosY /* System.Single */;
    [SerializeField] public global::Kingmaker.UI._ConsoleUI.Overtips.OvertipsViewCombinePart m_OvertipCombinePart /* Kingmaker.UI._ConsoleUI.Overtips.OvertipsViewCombinePart */;
    [SerializeField] public global::Kingmaker.UI._ConsoleUI.Overtips.OvertipsViewCombinePartConsole m_OvertipCombinePartConsole /* Kingmaker.UI._ConsoleUI.Overtips.OvertipsViewCombinePartConsole */;

    public class UIInteractionTypeSprites {
        public global::UnityEngine.Sprite Main /* UnityEngine.Sprite */;
        public global::UnityEngine.Sprite Active /* UnityEngine.Sprite */;
        public global::UnityEngine.Sprite Hover /* UnityEngine.Sprite */;
    }

}

}

