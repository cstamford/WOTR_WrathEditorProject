using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.MVVM._PCView.Rest {

public class RestCraftProgressBarPoint : MonoBehaviour {
    [SerializeField] public Image m_BorderImage /* UnityEngine.UI.Image */;
    [SerializeField] public GameObject m_BackgroundImage /* UnityEngine.GameObject */;
    [SerializeField] public object m_Text /* TMPro.TextMeshProUGUI */;
    [SerializeField] public Color m_ActiveColor /* UnityEngine.Color */;
    [SerializeField] public Color m_InactiveColor /* UnityEngine.Color */;
}

}

