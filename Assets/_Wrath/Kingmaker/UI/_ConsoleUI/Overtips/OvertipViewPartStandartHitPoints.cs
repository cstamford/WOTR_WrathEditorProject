using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI._ConsoleUI.Overtips {

public class OvertipViewPartStandartHitPoints : global::Kingmaker.UI._ConsoleUI.Overtips.OvertipViewPartBase {
    [SerializeField] public global::UnityEngine.UI.Image m_HitsBar /* UnityEngine.UI.Image */;
    [SerializeField] public _2dxFX_EnergyBar m_HitsBarEnergyFx /* ._2dxFX_EnergyBar */;
    [SerializeField] public global::UnityEngine.AnimationCurve m_CorrcetionCurve /* UnityEngine.AnimationCurve */;
    [SerializeField] public object m_DestroyAnimator /* Kingmaker.UI.Common.Animations.DestroyAnimator[] */;
    [SerializeField] public global::UnityEngine.UI.Image m_Background /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.Sprite m_EnemyBackground /* UnityEngine.Sprite */;
    [SerializeField] public global::UnityEngine.Sprite m_AllyBackground /* UnityEngine.Sprite */;
    [SerializeField] public global::UnityEngine.Sprite m_DefaultBackground /* UnityEngine.Sprite */;
}

}

