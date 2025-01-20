using System;
using UnityEngine;

namespace Kingmaker.UI.ServiceWindow.Credits {

public class OneColum : global::Kingmaker.UI.ServiceWindow.Credits.CreditElement {
    [SerializeField] public global::UnityEngine.CanvasGroup m_Group /* UnityEngine.CanvasGroup */;
    [SerializeField] public global::Kingmaker.UI.ServiceWindow.Credits.PersonElement m_PersonPrefab /* Kingmaker.UI.ServiceWindow.Credits.PersonElement */;
    [SerializeField] public global::Kingmaker.UI.ServiceWindow.Credits.HeaderElement m_HeaderPrefab /* Kingmaker.UI.ServiceWindow.Credits.HeaderElement */;
    [SerializeField] public global::Kingmaker.UI.ServiceWindow.Credits.TextElement m_TextPrefab /* Kingmaker.UI.ServiceWindow.Credits.TextElement */;
    [SerializeField] public global::UnityEngine.GameObject m_Separator /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.RectTransform m_Content /* UnityEngine.RectTransform */;
    public object m_Rows /* System.Collections.Generic.List */;
}

}

