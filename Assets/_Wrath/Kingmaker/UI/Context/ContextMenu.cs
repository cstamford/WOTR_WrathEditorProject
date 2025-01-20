using System;
using UnityEngine;

namespace Kingmaker.UI.Context {

public class ContextMenu : global::UnityEngine.MonoBehaviour {
    [SerializeField] public object m_Style /* Kingmaker.UI.Context.ContextMenuStyle */;
    [SerializeField] public global::UnityEngine.CanvasGroup m_Group /* UnityEngine.CanvasGroup */;
    [SerializeField] public global::UnityEngine.RectTransform m_Root /* UnityEngine.RectTransform */;
    [SerializeField] public global::UnityEngine.RectTransform m_Viewport /* UnityEngine.RectTransform */;
    [SerializeField] public global::UnityEngine.GameObject m_TitlePrefab /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.GameObject m_ButtonPrefab /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.GameObject m_SeparatorPrefab /* UnityEngine.GameObject */;

    public class AlignData {
        [SerializeField] public global::UnityEngine.Vector2 m_OrginPivot /* UnityEngine.Vector2 */;
        [SerializeField] public global::UnityEngine.Vector2 m_ContextPivot /* UnityEngine.Vector2 */;
    }

}

}

