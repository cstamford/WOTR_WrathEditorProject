using Kingmaker.UI.Common.Animations;
using Kingmaker.UI.LoadingScreen;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.MVVM._PCView.LoadingScreen {

public class LoadingScreenPCView {
    [SerializeField] public global::Kingmaker.UI.Common.Animations.FadeAnimator m_FadeAnimator /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    [SerializeField] public global::Kingmaker.UI.LoadingScreen.LoadingScreenHints m_Hints /* Kingmaker.UI.LoadingScreen.LoadingScreenHints */;
    [SerializeField] public object m_Hint /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.GameObject m_MapContainer /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.UI.Image m_Picture /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.UI.Image m_CharacterPortrait /* UnityEngine.UI.Image */;
    [SerializeField] public object m_CharacterNameText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_CharacterDescriptionText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.UI.Image ProgressImage /* UnityEngine.UI.Image */;
    [SerializeField] public object m_ProgressText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.Sprite m_PrologueCaves1Sprite /* UnityEngine.Sprite */;
}

}

