using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.GlobalMap.Teleport {

public class TeleportWindowBuildingItemView : global::UnityEngine.MonoBehaviour {
    [SerializeField] public object m_Title /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_Type /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_Region /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.UI.Image m_Border /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.UI.Image m_Background /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.Color m_SelectColor /* UnityEngine.Color */;
    [SerializeField] public global::UnityEngine.Color m_UnSelectColor /* UnityEngine.Color */;
}

}

