using Kingmaker.UI.Common.Animations;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.GlobalMap {

public class GlobalMapMainMenu : MonoBehaviour {
    [SerializeField] public object m_LocationName /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_Clock /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_Date /* TMPro.TextMeshProUGUI */;
    [SerializeField] public Toggle m_ShowLocName /* UnityEngine.UI.Toggle */;
    [SerializeField] public Transform m_Spectre /* UnityEngine.Transform */;
    [SerializeField] public MoveAnimator m_MoveAnimator /* Kingmaker.UI.Common.Animations.MoveAnimator */;
}

}

