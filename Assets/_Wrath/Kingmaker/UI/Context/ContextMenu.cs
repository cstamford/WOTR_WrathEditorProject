using System;
using UnityEngine;

namespace Kingmaker.UI.Context {

public class ContextMenu : MonoBehaviour {
    [SerializeField] public object m_Style /* Kingmaker.UI.Context.ContextMenuStyle */;
    [SerializeField] public CanvasGroup m_Group /* UnityEngine.CanvasGroup */;
    [SerializeField] public RectTransform m_Root /* UnityEngine.RectTransform */;
    [SerializeField] public RectTransform m_Viewport /* UnityEngine.RectTransform */;
    [SerializeField] public GameObject m_TitlePrefab /* UnityEngine.GameObject */;
    [SerializeField] public GameObject m_ButtonPrefab /* UnityEngine.GameObject */;
    [SerializeField] public GameObject m_SeparatorPrefab /* UnityEngine.GameObject */;

    public class AlignData {
        [SerializeField] public Vector2 m_OrginPivot /* UnityEngine.Vector2 */;
        [SerializeField] public Vector2 m_ContextPivot /* UnityEngine.Vector2 */;
    }

}

}

