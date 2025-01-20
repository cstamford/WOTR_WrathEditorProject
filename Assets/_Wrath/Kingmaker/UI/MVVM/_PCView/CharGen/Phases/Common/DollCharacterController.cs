using Kingmaker.UI.Common.Animations;
using Kingmaker.UI.ServiceWindow;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.MVVM._PCView.CharGen.Phases.Common {

public class DollCharacterController : global::UnityEngine.MonoBehaviour {
    [SerializeField] public global::Kingmaker.UI.ServiceWindow.DollRoomCharacterController m_CharacterController /* Kingmaker.UI.ServiceWindow.DollRoomCharacterController */;
    [SerializeField] public global::UnityEngine.UI.RawImage m_DollRoom /* UnityEngine.UI.RawImage */;
    [SerializeField] public global::Kingmaker.UI.Common.Animations.FadeAnimator m_DollFadeAnimator /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    [SerializeField] public float m_ZoomMinValue /* System.Single */;
    [SerializeField] public global::UnityEngine.UI.RawImage m_DollPlaceHolder /* UnityEngine.UI.RawImage */;
    [SerializeField] public global::Kingmaker.UI.Common.Animations.FadeAnimator m_DollPlaceHolderAnimator /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    [SerializeField] public float m_RotateFactor /* System.Single */;
}

}

