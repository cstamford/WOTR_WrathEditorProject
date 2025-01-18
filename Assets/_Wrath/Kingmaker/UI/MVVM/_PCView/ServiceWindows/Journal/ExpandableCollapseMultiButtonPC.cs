using Kingmaker.UI.Common.Animations;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._PCView.ServiceWindows.Journal {

public class ExpandableCollapseMultiButtonPC : MonoBehaviour {
    [SerializeField] public object m_MultiButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
    [SerializeField] public Transform m_CollapseImage /* UnityEngine.Transform */;
    [SerializeField] public FadeAnimator m_FadeAnimator /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    [SerializeField] public bool m_IsOn /* System.Boolean */;
    [SerializeField] public bool m_IsSwitchMultiButtonLayer /* System.Boolean */;
}

}

