using Kingmaker.UI.Common.Animations;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.GlobalMap {

public class GlobalMapMainMenu : global::UnityEngine.MonoBehaviour {
    [SerializeField] public object m_LocationName /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_Clock /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_Date /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.UI.Toggle m_ShowLocName /* UnityEngine.UI.Toggle */;
    [SerializeField] public global::UnityEngine.Transform m_Spectre /* UnityEngine.Transform */;
    [SerializeField] public global::Kingmaker.UI.Common.Animations.MoveAnimator m_MoveAnimator /* Kingmaker.UI.Common.Animations.MoveAnimator */;
}

}

