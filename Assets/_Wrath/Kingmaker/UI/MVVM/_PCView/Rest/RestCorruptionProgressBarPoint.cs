using UnityEngine;

namespace Kingmaker.UI.MVVM._PCView.Rest {

public class RestCorruptionProgressBarPoint : MonoBehaviour {
    [SerializeField] public RectTransform m_Rect /* UnityEngine.RectTransform */;
    [SerializeField] public object m_LevelText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public GameObject m_ActiveStateObject /* UnityEngine.GameObject */;
    [SerializeField] public GameObject m_InactiveStateObject /* UnityEngine.GameObject */;
    [SerializeField] public Color m_ActiveStateTextColor /* UnityEngine.Color */;
    [SerializeField] public Color m_InactiveStateTextColor /* UnityEngine.Color */;
}

}

