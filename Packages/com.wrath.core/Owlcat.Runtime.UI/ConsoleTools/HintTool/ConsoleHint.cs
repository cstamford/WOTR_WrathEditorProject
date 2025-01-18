using System;
using UnityEngine;
using UnityEngine.UI;

namespace Owlcat.Runtime.UI.ConsoleTools.HintTool {

public class ConsoleHint : MonoBehaviour {
    [SerializeField] public CanvasGroup m_CanvasGroup /* UnityEngine.CanvasGroup */;
    [SerializeField] public Image m_Icon /* UnityEngine.UI.Image */;
    [SerializeField] public Image m_ProgressBar /* UnityEngine.UI.Image */;
    [SerializeField] public Image m_ProgressHint /* UnityEngine.UI.Image */;
    [SerializeField] public object m_Label /* TMPro.TextMeshProUGUI */;
    [SerializeField] public ConsoleHint.ConsoleHintAnimation m_Animation /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHintAnimation */;
    [SerializeField] public float m_ScaleFactor /* System.Single */;
    [SerializeField] public float m_AnimTime /* System.Single */;

    public enum ConsoleHintAnimation {
        None = 0,
        Scale = 1,
        Move = 2,
    }

}

}

