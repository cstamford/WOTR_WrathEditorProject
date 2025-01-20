using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.Common {

public class PageNavigation : global::UnityEngine.MonoBehaviour {
    [SerializeField] public object m_PreviousButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
    [SerializeField] public object m_NextButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
    [SerializeField] public global::UnityEngine.UI.Image m_PointPrefab /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.Transform m_PointsContainer /* UnityEngine.Transform */;
    [SerializeField] public global::UnityEngine.Sprite m_SelectedSprite /* UnityEngine.Sprite */;
    [SerializeField] public global::UnityEngine.Sprite m_UnselectedSprite /* UnityEngine.Sprite */;
}

}

