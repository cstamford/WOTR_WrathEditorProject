using Kingmaker.UI.Vendor;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.Loot {

public class LootCollector : MonoBehaviour {
    [SerializeField] public object m_LootObjectPrefab /* Kingmaker.UI.Loot.LootObject */;
    [SerializeField] public Transform m_ObjectsContainer /* UnityEngine.Transform */;
    [SerializeField] public RectTransform m_ObjectsContainerRectTransform /* UnityEngine.RectTransform */;
    [SerializeField] public VerticalLayoutGroup m_ObjectsContainerLayout /* UnityEngine.UI.VerticalLayoutGroup */;
    [SerializeField] public RectTransform m_ScrollViewContainer /* UnityEngine.RectTransform */;
    [SerializeField] public object m_HeaderTitle /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_LootEncumbranceContainer /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_ItemsCounter /* TMPro.TextMeshProUGUI */;
    [SerializeField] public GameObject m_Space /* UnityEngine.GameObject */;
    [SerializeField] public FilterController Filters /* Kingmaker.UI.Vendor.FilterController */;
    [SerializeField] public object m_ButtonCollectAllLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public Button m_ButtonCollectAll /* UnityEngine.UI.Button */;
    [SerializeField] public object m_ButtonSkinningLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public Button m_ButtonSkinning /* UnityEngine.UI.Button */;
    [SerializeField] public float m_MaxHeigthShort /* System.Single */;
    [SerializeField] public float m_MaxHeigthStash /* System.Single */;
    public bool HasItemsToSkinning /* System.Boolean */;
    public bool isSingleObject /* System.Boolean */;
}

}

