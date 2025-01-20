using Kingmaker.UI.Common.Animations;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._ConsoleView.CharGen {

public class RespecWindowConsoleView {
    [SerializeField] public global::Kingmaker.UI.Common.Animations.FadeAnimator m_FadeAnimator /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    [SerializeField] public global::Kingmaker.UI.Common.Animations.WindowAnimator m_WindowAnimator /* Kingmaker.UI.Common.Animations.WindowAnimator */;
    [SerializeField] public object m_Title /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_CharacterName /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_MythicPath /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
    [SerializeField] public object m_LevelUp /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
    [SerializeField] public object m_MythicUpRestrictionTitle /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_LevelupButtonTitle /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_MythicUpTitle /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_MythicVisualVariantView /* Kingmaker.UI.MVVM._VM.DLC5.MythicVisualVariantView[] */;
    [SerializeField] public object m_ConsoleHintsWidget /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHintsWidget */;
    [SerializeField] public global::UnityEngine.GameObject m_MythicUpRestriction /* UnityEngine.GameObject */;
    public object m_CanLevelUp /* UniRx.BoolReactiveProperty */;
    public object m_CanMythicPath /* UniRx.BoolReactiveProperty */;
    public object m_CanMaxLevelUp /* UniRx.BoolReactiveProperty */;
    public object m_CanMaxMythicPath /* UniRx.BoolReactiveProperty */;
}

}

