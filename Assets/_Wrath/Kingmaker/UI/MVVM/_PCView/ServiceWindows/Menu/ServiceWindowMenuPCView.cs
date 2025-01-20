using Kingmaker.UI.Common.Animations;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._PCView.ServiceWindows.Menu {

public class ServiceWindowMenuPCView {
    [SerializeField] public global::Kingmaker.UI.Common.Animations.FadeAnimator m_Animator /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.ServiceWindows.Menu.ServiceWindowMenuSelectorPCView m_MenuSelector /* Kingmaker.UI.MVVM._PCView.ServiceWindows.Menu.ServiceWindowMenuSelectorPCView */;
    [SerializeField] public object m_CloseButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
}

}

