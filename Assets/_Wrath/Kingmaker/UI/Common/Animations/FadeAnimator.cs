using System;
using UnityEngine;

namespace Kingmaker.UI.Common.Animations {

public class FadeAnimator : MonoBehaviour {
    [SerializeField] public float m_AppearTime /* System.Single */;
    [SerializeField] public object m_AppearAnimCurve /* DG.Tweening.Ease */;
    [SerializeField] public float m_DisappearTime /* System.Single */;
    [SerializeField] public object m_DisappearAnimCurve /* DG.Tweening.Ease */;
    [SerializeField] public bool m_GameObjectAlwaysActive /* System.Boolean */;
}

}

