using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.GlobalMap.Teleport {

public class TeleportWindowBuildingItemView : MonoBehaviour {
    [SerializeField] public object m_Title /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_Type /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_Region /* TMPro.TextMeshProUGUI */;
    [SerializeField] public Image m_Border /* UnityEngine.UI.Image */;
    [SerializeField] public Image m_Background /* UnityEngine.UI.Image */;
    [SerializeField] public Color m_SelectColor /* UnityEngine.Color */;
    [SerializeField] public Color m_UnSelectColor /* UnityEngine.Color */;
}

}

