using Kingmaker.UI;
using Kingmaker.UI.SaveLoadWindow;
using UnityEngine;

namespace Kingmaker.UI.Canvases {

public class BaseGameOverCanvas : MonoBehaviour {
    [SerializeField] public GameOverManager GameOverManager /* Kingmaker.UI.GameOverManager */;
    [SerializeField] public Kingmaker.UI.SaveLoadWindow.SaveLoadWindow m_SaveLoadWindow /* Kingmaker.UI.SaveLoadWindow.SaveLoadWindow */;
}

}

