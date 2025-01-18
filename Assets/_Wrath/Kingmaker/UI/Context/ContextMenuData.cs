using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.UI.Context {

public class ContextMenuData : MonoBehaviour {
    [SerializeField] public object m_Style /* Kingmaker.UI.Context.ContextMenuStyle */;
    [SerializeField] public RectTransform m_Frame /* UnityEngine.RectTransform */;
    [SerializeField] public List<ContextMenu.AlignData> m_Aligns /* System.Collections.Generic.List<Kingmaker.UI.Context.AlignData> */;
    [SerializeField] public object m_Items /* System.Collections.Generic.List */;
}

}

