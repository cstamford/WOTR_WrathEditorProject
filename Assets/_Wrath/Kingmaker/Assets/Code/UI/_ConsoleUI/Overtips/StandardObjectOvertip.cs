using Kingmaker.UI._ConsoleUI.Overtips;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.Assets.Code.UI._ConsoleUI.Overtips {

public class StandardObjectOvertip : global::Kingmaker.UI._ConsoleUI.Overtips.OvertipViewBase {
    public float TweenDuration /* System.Single */;
    [SerializeField] public global::Kingmaker.UI._ConsoleUI.Overtips.OvertipViewPartName m_OvertipViewPartName /* Kingmaker.UI._ConsoleUI.Overtips.OvertipViewPartName */;
    public global::Kingmaker.UI._ConsoleUI.Overtips.OvertipViewPartBark OvertipViewPartBarkPrefab /* Kingmaker.UI._ConsoleUI.Overtips.OvertipViewPartBark */;
    [SerializeField] public float m_OvertipPosY /* System.Single */;
    public object DescriptionText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.GameObject m_NextInteractableHintsGameObject /* UnityEngine.GameObject */;
    [SerializeField] public object m_ActionHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_AdditionalLiftNextHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_AdditionalRightNextHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public global::UnityEngine.UI.Image m_Image /* UnityEngine.UI.Image */;
    public global::Kingmaker.Assets.Code.UI._ConsoleUI.Overtips.ObjectInteractionOvertipView.UIInteractionTypeSprites ActionSprites /* Kingmaker.Assets.Code.UI._ConsoleUI.Overtips.UIInteractionTypeSprites */;
    public global::Kingmaker.Assets.Code.UI._ConsoleUI.Overtips.ObjectInteractionOvertipView.UIInteractionTypeSprites MoveSprites /* Kingmaker.Assets.Code.UI._ConsoleUI.Overtips.UIInteractionTypeSprites */;
    public global::Kingmaker.Assets.Code.UI._ConsoleUI.Overtips.ObjectInteractionOvertipView.UIInteractionTypeSprites InfoSprites /* Kingmaker.Assets.Code.UI._ConsoleUI.Overtips.UIInteractionTypeSprites */;
    public object SkillcheckText /* TMPro.TextMeshProUGUI */;
    public global::UnityEngine.CanvasGroup DescriptionCanvas /* UnityEngine.CanvasGroup */;
}

}

