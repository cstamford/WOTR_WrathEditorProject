using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.SaveLoadWindow {

public class SaveInjectorView : MonoBehaviour {
    [SerializeField] public object m_Header /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_Hint /* TMPro.TextMeshProUGUI */;
    [SerializeField] public Button m_CloseBtn /* UnityEngine.UI.Button */;
    [SerializeField] public Button m_AcceptBtn /* UnityEngine.UI.Button */;
    [SerializeField] public ListOfSaves m_ListOfSaves /* Kingmaker.UI.SaveLoadWindow.ListOfSaves */;
}

}

