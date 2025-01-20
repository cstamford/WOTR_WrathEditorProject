using System;
using UnityEngine;

namespace Kingmaker.UI.Common {

public class SelectableLinkConsole : global::UnityEngine.MonoBehaviour {
    [SerializeField] public global::UnityEngine.RectTransform m_SelectingPlace /* UnityEngine.RectTransform */;
    [SerializeField] public global::UnityEngine.CanvasGroup m_SelectingLinkEntity /* UnityEngine.CanvasGroup */;
    [SerializeField] public global::UnityEngine.RectTransform m_TooltipPlace /* UnityEngine.RectTransform */;
    [SerializeField] public object m_Text /* System.Collections.Generic.List */;
    public object HaveAnyGlossaryPoints /* UniRx.BoolReactiveProperty */;
    public object IsGlossaryMode /* UniRx.BoolReactiveProperty */;
}

}

