using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.BookEvent {

public class BookEventBaseController : MonoBehaviour {
    public Image Picture /* UnityEngine.UI.Image */;
    [SerializeField] public Transform m_Window /* UnityEngine.Transform */;
    [SerializeField] public float FadeTime /* System.Single */;
    [SerializeField] public CanvasGroup m_ContentCanvasGroup /* UnityEngine.CanvasGroup */;
}

}

