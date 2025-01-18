using Kingmaker.UI.Common.Animations;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.CharSelect {

public class CharSelectWindow : MonoBehaviour {
    [SerializeField] public object m_OkButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public Transform m_ItemsContainer /* UnityEngine.Transform */;
    [SerializeField] public WindowAnimator m_WindowAnimator /* Kingmaker.UI.Common.Animations.WindowAnimator */;
    [SerializeField] public FadeAnimator m_BgAnimator /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    [SerializeField] public HeroPortraitButton m_PortraitSlectorItem /* Kingmaker.UI.CharSelect.HeroPortraitButton */;
    [SerializeField] public ToggleGroup m_ToggleGroup /* UnityEngine.UI.ToggleGroup */;
}

}

