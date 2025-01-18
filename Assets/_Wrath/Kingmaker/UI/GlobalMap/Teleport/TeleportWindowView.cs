using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.GlobalMap.Teleport {

public class TeleportWindowView : MonoBehaviour {
    [SerializeField] public object m_Title /* TMPro.TextMeshProUGUI */;
    [SerializeField] public RectTransform m_Content /* UnityEngine.RectTransform */;
    [SerializeField] public TeleportWindowBuildingItemView m_BuildingItem /* Kingmaker.UI.GlobalMap.Teleport.TeleportWindowBuildingItemView */;
    [SerializeField] public Button m_GoButton /* UnityEngine.UI.Button */;
}

}

