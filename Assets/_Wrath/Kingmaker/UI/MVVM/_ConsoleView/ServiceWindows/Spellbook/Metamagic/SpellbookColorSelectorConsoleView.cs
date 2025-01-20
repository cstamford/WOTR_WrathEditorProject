using Kingmaker.UI.Common.Animations;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.Spellbook.Metamagic {

public class SpellbookColorSelectorConsoleView {
    [SerializeField] public object m_MultiButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
    [SerializeField] public global::UnityEngine.UI.Image m_Color /* UnityEngine.UI.Image */;
    [SerializeField] public global::Kingmaker.UI.Common.Animations.FadeAnimator m_ColorPlane /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    [SerializeField] public object m_DeclineHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_ChangeColorHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
}

}

