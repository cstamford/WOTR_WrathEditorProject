using UnityEngine;

namespace Kingmaker.UI.Common {

public class SelectableLinkConsole : MonoBehaviour {
    [SerializeField] public RectTransform m_SelectingPlace /* UnityEngine.RectTransform */;
    [SerializeField] public CanvasGroup m_SelectingLinkEntity /* UnityEngine.CanvasGroup */;
    [SerializeField] public RectTransform m_TooltipPlace /* UnityEngine.RectTransform */;
    [SerializeField] public object m_Text /* System.Collections.Generic.List */;
    public object HaveAnyGlossaryPoints /* UniRx.BoolReactiveProperty */;
    public object IsGlossaryMode /* UniRx.BoolReactiveProperty */;
}

}

