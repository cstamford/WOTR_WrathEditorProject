using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.SaveLoadWindow {

public class RootSaveSlot : MonoBehaviour {
    [SerializeField] public object m_Label /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_HighlightLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public Transform m_ExpandArrow /* UnityEngine.Transform */;
    public GameObject[] m_HighlightObjects /* UnityEngine.GameObject[] */;
    [SerializeField] public Button m_Button /* UnityEngine.UI.Button */;
}

}

