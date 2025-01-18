using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.Kingdom {

public class KingdomUIEventWindow : MonoBehaviour {
    [SerializeField] public Image m_NewEvent /* UnityEngine.UI.Image */;
    [SerializeField] public object m_Title /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_TitleNavigation /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_Repeatable /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_Duration /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_Description /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_ResultDescription /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_MechanicalDescription /* TMPro.TextMeshProUGUI */;
    [SerializeField] public KingdomUIEventWindowFooter m_Footer /* Kingmaker.UI.Kingdom.KingdomUIEventWindowFooter */;
    [SerializeField] public RectTransform m_Window /* UnityEngine.RectTransform */;
    [SerializeField] public RectTransform m_Navigation /* UnityEngine.RectTransform */;
    [SerializeField] public object m_PrevButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public object m_NextButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
}

}

