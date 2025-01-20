using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.GlobalMap.Teleport {

public class TeleportWindowView : global::UnityEngine.MonoBehaviour {
    [SerializeField] public object m_Title /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.RectTransform m_Content /* UnityEngine.RectTransform */;
    [SerializeField] public global::Kingmaker.UI.GlobalMap.Teleport.TeleportWindowBuildingItemView m_BuildingItem /* Kingmaker.UI.GlobalMap.Teleport.TeleportWindowBuildingItemView */;
    [SerializeField] public global::UnityEngine.UI.Button m_GoButton /* UnityEngine.UI.Button */;
}

}

