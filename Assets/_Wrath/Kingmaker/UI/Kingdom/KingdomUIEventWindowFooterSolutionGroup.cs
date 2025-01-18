using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.Kingdom {

public class KingdomUIEventWindowFooterSolutionGroup : MonoBehaviour {
    [SerializeField] public object m_Label /* TMPro.TextMeshProUGUI */;
    [SerializeField] public KingdomUIEventWindowFooterSolution m_SolutionPrefab /* Kingmaker.UI.Kingdom.KingdomUIEventWindowFooterSolution */;
    [SerializeField] public ToggleGroup m_ToggleGroup /* UnityEngine.UI.ToggleGroup */;
}

}

