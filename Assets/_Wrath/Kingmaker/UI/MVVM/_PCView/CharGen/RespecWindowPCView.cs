using Kingmaker.UI.Common.Animations;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._PCView.CharGen {

public class RespecWindowPCView {
    [SerializeField] public global::Kingmaker.UI.Common.Animations.FadeAnimator m_FadeAnimator /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    [SerializeField] public global::Kingmaker.UI.Common.Animations.WindowAnimator m_WindowAnimator /* Kingmaker.UI.Common.Animations.WindowAnimator */;
    [SerializeField] public object m_Title /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_CharacterName /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_LevelupButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
    [SerializeField] public object m_MaxLevelupButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
    [SerializeField] public object m_LevelupButtonTitle /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_MythicUpButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
    [SerializeField] public object m_MaxMythicUpButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
    [SerializeField] public object m_MythicUpTitle /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.GameObject m_MythicUpRestriction /* UnityEngine.GameObject */;
    [SerializeField] public object m_MythicUpRestrictionTitle /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_MythicVisualVariantView /* Kingmaker.UI.MVVM._VM.DLC5.MythicVisualVariantView[] */;
    [SerializeField] public object m_CompleteButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public object m_CompleteButtonTitle /* TMPro.TextMeshProUGUI */;
}

}

