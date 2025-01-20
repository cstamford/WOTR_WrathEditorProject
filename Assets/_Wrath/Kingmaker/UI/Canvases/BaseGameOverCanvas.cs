using Kingmaker.UI;
using Kingmaker.UI.SaveLoadWindow;
using System;
using UnityEngine;

namespace Kingmaker.UI.Canvases {

public class BaseGameOverCanvas : global::UnityEngine.MonoBehaviour {
    [SerializeField] public global::Kingmaker.UI.GameOverManager GameOverManager /* Kingmaker.UI.GameOverManager */;
    [SerializeField] public global::Kingmaker.UI.SaveLoadWindow.SaveLoadWindow m_SaveLoadWindow /* Kingmaker.UI.SaveLoadWindow.SaveLoadWindow */;
}

}

