using Kingmaker.UI.Common.Animations;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI {

public class GameOverManager : MonoBehaviour {
    [SerializeField] public WindowAnimator m_Window /* Kingmaker.UI.Common.Animations.WindowAnimator */;
    [SerializeField] public object m_PostGameLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public Button m_RavenButton /* UnityEngine.UI.Button */;
    [SerializeField] public GameObject m_SetEasyObject /* UnityEngine.GameObject */;
    [SerializeField] public Toggle m_SetEasyToggle /* UnityEngine.UI.Toggle */;
    [SerializeField] public Button m_LoadButon /* UnityEngine.UI.Button */;
}

}

