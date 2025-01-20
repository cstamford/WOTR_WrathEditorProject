using Kingmaker.UI.Common.Animations;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI {

public class GameOverManager : global::UnityEngine.MonoBehaviour {
    [SerializeField] public global::Kingmaker.UI.Common.Animations.WindowAnimator m_Window /* Kingmaker.UI.Common.Animations.WindowAnimator */;
    [SerializeField] public object m_PostGameLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.UI.Button m_RavenButton /* UnityEngine.UI.Button */;
    [SerializeField] public global::UnityEngine.GameObject m_SetEasyObject /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.UI.Toggle m_SetEasyToggle /* UnityEngine.UI.Toggle */;
    [SerializeField] public global::UnityEngine.UI.Button m_LoadButon /* UnityEngine.UI.Button */;
}

}

