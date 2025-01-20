using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.UI.Context {

public class ContextMenuData : global::UnityEngine.MonoBehaviour {
    [SerializeField] public object m_Style /* Kingmaker.UI.Context.ContextMenuStyle */;
    [SerializeField] public global::UnityEngine.RectTransform m_Frame /* UnityEngine.RectTransform */;
    [SerializeField] public global::System.Collections.Generic.List<global::Kingmaker.UI.Context.ContextMenu.AlignData> m_Aligns /* System.Collections.Generic.List<Kingmaker.UI.Context.AlignData> */;
    [SerializeField] public object m_Items /* System.Collections.Generic.List */;
}

}

