using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.MVVM._PCView.Rest {

public class RestCraftProgressBar : MonoBehaviour {
    [SerializeField] public Slider m_ProgressBar /* UnityEngine.UI.Slider */;
    [SerializeField] public Image m_SelectIconImage /* UnityEngine.UI.Image */;
    [SerializeField] public Image m_ItemIconImage /* UnityEngine.UI.Image */;
    [SerializeField] public HorizontalLayoutGroup m_LayoutGroup /* UnityEngine.UI.HorizontalLayoutGroup */;
    [SerializeField] public List<RestCraftProgressBarPoint> m_Points /* System.Collections.Generic.List<Kingmaker.UI.MVVM._PCView.Rest.RestCraftProgressBarPoint> */;
    [SerializeField] public RectTransform m_ContainerRect /* UnityEngine.RectTransform */;
    [SerializeField] public RectTransform m_PointRect /* UnityEngine.RectTransform */;
    [SerializeField] public object m_DescText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_ItemNameText /* TMPro.TextMeshProUGUI */;
}

}

