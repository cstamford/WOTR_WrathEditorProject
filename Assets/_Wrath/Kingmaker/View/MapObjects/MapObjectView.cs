using Kingmaker.View;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.View.MapObjects {

public class MapObjectView {
    [SerializeField] public global::System.Collections.Generic.List<global::UnityEngine.Renderer> m_HideRenderers /* System.Collections.Generic.List<UnityEngine.Renderer> */;
    [SerializeField] public global::System.Collections.Generic.List<global::UnityEngine.GameObject> m_ShowObjectsOnHighlight /* System.Collections.Generic.List<UnityEngine.GameObject> */;
    public bool AreaHighlighted /* System.Boolean */;
    public object IsAreaHighlighted /* UniRx.BoolReactiveProperty */;
}

}

