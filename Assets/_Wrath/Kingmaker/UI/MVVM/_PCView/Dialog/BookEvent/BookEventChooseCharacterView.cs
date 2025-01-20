using Kingmaker.UI.Common;
using Kingmaker.UI.Common.Animations;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._PCView.Dialog.BookEvent {

public class BookEventChooseCharacterView {
    [SerializeField] public global::Kingmaker.UI.Common.Animations.FadeAnimator m_WindowAnimator /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    [SerializeField] public global::Kingmaker.UI.Common.WidgetListMVVM m_WidgetListCharacter /* Kingmaker.UI.Common.WidgetListMVVM */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Dialog.BookEvent.BookEventCharacterView m_BookEventCharacterViewPrefab /* Kingmaker.UI.MVVM._PCView.Dialog.BookEvent.BookEventCharacterView */;
    [SerializeField] public global::Kingmaker.UI.Common.WidgetListMVVM m_WidgetListSkills /* Kingmaker.UI.Common.WidgetListMVVM */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Dialog.BookEvent.BookEventSkillsBlockView m_BookEventSkillsBlockViewPrefab /* Kingmaker.UI.MVVM._PCView.Dialog.BookEvent.BookEventSkillsBlockView */;
    [SerializeField] public object m_Title /* TMPro.TextMeshProUGUI */;
}

}

