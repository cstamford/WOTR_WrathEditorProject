using Kingmaker.UI.Common.Animations;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._PCView.Settings.KeyBindSetupDialog {

public class KeyBindingSetupDialogPCView {
    [SerializeField] public object m_PressedKeysText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_BindingIsOccupied /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.Color m_NormalColor /* UnityEngine.Color */;
    [SerializeField] public global::UnityEngine.Color m_TempColor /* UnityEngine.Color */;
    [SerializeField] public global::UnityEngine.Color m_OccupiedColor /* UnityEngine.Color */;
    [SerializeField] public object m_CloseButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public object m_UnbindButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public global::Kingmaker.UI.Common.Animations.FadeAnimator m_Animator /* Kingmaker.UI.Common.Animations.FadeAnimator */;
}

}

