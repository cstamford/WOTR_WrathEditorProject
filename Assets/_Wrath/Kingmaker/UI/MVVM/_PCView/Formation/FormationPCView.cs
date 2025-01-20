using Kingmaker.UI.Common.Animations;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._PCView.Formation {

public class FormationPCView {
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Formation.FormationSelectorPCView m_FormationSelectorPCView /* Kingmaker.UI.MVVM._PCView.Formation.FormationSelectorPCView */;
    [SerializeField] public global::UnityEngine.RectTransform m_CharacterContainer /* UnityEngine.RectTransform */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Formation.FormationCharacterPCView m_CharacterView /* Kingmaker.UI.MVVM._PCView.Formation.FormationCharacterPCView */;
    [SerializeField] public object m_CloseButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public object m_PreserveFormationMultiButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
    [SerializeField] public object m_RestoreToDefaultButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public object m_HoldTheLineText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_RestoreToDefaultText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.Common.Animations.FadeAnimator m_FadeAnimator /* Kingmaker.UI.Common.Animations.FadeAnimator */;
}

}

