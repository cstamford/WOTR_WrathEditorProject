using DG.Tweening;
using Kingmaker.UI.Common.Animations;
using Kingmaker.UI.SettingsUI;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.ServiceWindow {

public class SettingsUIWindow {
    [SerializeField] public global::Kingmaker.UI.Common.Animations.FadeAnimator m_TableBackground /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    [SerializeField] public global::Kingmaker.UI.Common.Animations.MoveAnimator m_Header /* Kingmaker.UI.Common.Animations.MoveAnimator */;
    [SerializeField] public global::Kingmaker.UI.Common.Animations.FadeAnimator m_MainContainer /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    [SerializeField] public global::UnityEngine.Transform m_Bookmark /* UnityEngine.Transform */;
    [SerializeField] public global::DG.Tweening.DOTweenAnimation m_Light /* DG.Tweening.DOTweenAnimation */;
    public global::Kingmaker.UI.SettingsUI.SettingsListScreen SettingsListScreen /* Kingmaker.UI.SettingsUI.SettingsListScreen */;
    [SerializeField] public global::Kingmaker.UI.SettingsUI.SettingsDescription m_SettingsDescription /* Kingmaker.UI.SettingsUI.SettingsDescription */;
    [SerializeField] public global::UnityEngine.UI.Button m_Apply /* UnityEngine.UI.Button */;
    [SerializeField] public object m_ApplyText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.UI.Button m_Default /* UnityEngine.UI.Button */;
    [SerializeField] public object m_DefaultText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.UI.Button m_DifficultyButton /* UnityEngine.UI.Button */;
}

}

