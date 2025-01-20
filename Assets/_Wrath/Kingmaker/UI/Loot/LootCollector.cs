using Kingmaker.UI.Vendor;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.Loot {

public class LootCollector : global::UnityEngine.MonoBehaviour {
    [SerializeField] public global::Kingmaker.UI.Loot.LootObject m_LootObjectPrefab /* Kingmaker.UI.Loot.LootObject */;
    [SerializeField] public global::UnityEngine.Transform m_ObjectsContainer /* UnityEngine.Transform */;
    [SerializeField] public global::UnityEngine.RectTransform m_ObjectsContainerRectTransform /* UnityEngine.RectTransform */;
    [SerializeField] public global::UnityEngine.UI.VerticalLayoutGroup m_ObjectsContainerLayout /* UnityEngine.UI.VerticalLayoutGroup */;
    [SerializeField] public global::UnityEngine.RectTransform m_ScrollViewContainer /* UnityEngine.RectTransform */;
    [SerializeField] public object m_HeaderTitle /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_LootEncumbranceContainer /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_ItemsCounter /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.GameObject m_Space /* UnityEngine.GameObject */;
    [SerializeField] public global::Kingmaker.UI.Vendor.FilterController Filters /* Kingmaker.UI.Vendor.FilterController */;
    [SerializeField] public object m_ButtonCollectAllLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.UI.Button m_ButtonCollectAll /* UnityEngine.UI.Button */;
    [SerializeField] public object m_ButtonSkinningLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.UI.Button m_ButtonSkinning /* UnityEngine.UI.Button */;
    [SerializeField] public float m_MaxHeigthShort /* System.Single */;
    [SerializeField] public float m_MaxHeigthStash /* System.Single */;
    public bool HasItemsToSkinning /* System.Boolean */;
    public bool isSingleObject /* System.Boolean */;
}

}

