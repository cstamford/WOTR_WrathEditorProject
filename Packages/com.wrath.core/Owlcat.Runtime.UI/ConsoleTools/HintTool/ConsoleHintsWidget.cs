using UnityEngine;

namespace Owlcat.Runtime.UI.ConsoleTools.HintTool {

public class ConsoleHintsWidget : MonoBehaviour {
    [SerializeField] public ConsoleHint m_ConsoleHintPrefab /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public Transform m_LeftHintsContainer /* UnityEngine.Transform */;
    [SerializeField] public Transform m_CenterHintsContainer /* UnityEngine.Transform */;
    [SerializeField] public Transform m_RightHintsContainer /* UnityEngine.Transform */;
}

}

