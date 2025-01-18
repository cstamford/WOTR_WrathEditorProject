using UnityEngine;

namespace Kingmaker.UI.Tooltip {

public class PrerequisiteOrEntry : MonoBehaviour {
    [SerializeField] public object m_Text /* TMPro.TextMeshProUGUI */;
    [SerializeField] public GameObject m_Separator /* UnityEngine.GameObject */;
    [SerializeField] public Color32 m_DoneColor /* UnityEngine.Color32 */;
    [SerializeField] public Color32 m_RequiredColor /* UnityEngine.Color32 */;
}

}

