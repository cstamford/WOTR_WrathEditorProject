using Kingmaker.UI.Common;
using Kingmaker.UI.Common.Animations;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._PCView.GroupChanger {

public class GroupChangerPCView {
    [SerializeField] public object m_PartyHeader /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_RemoteHeader /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_AcceptButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public object m_CloseButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.GroupChanger.GroupChangerCharacterPCView m_CharacterView /* Kingmaker.UI.MVVM._PCView.GroupChanger.GroupChangerCharacterPCView */;
    [SerializeField] public global::UnityEngine.RectTransform m_PartyContainer /* UnityEngine.RectTransform */;
    [SerializeField] public global::Kingmaker.UI.Common.ScrollRectExtended m_RemoteContainer /* Kingmaker.UI.Common.ScrollRectExtended */;
    [SerializeField] public global::Kingmaker.UI.Common.Animations.WindowAnimator m_WindowAnimator /* Kingmaker.UI.Common.Animations.WindowAnimator */;
}

}

