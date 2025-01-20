using Kingmaker.UI.Common;
using Kingmaker.UI.ServiceWindow.Encyclopedia.Blocks;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.UI.ServiceWindow.Encyclopedia {

public class PageView : global::UnityEngine.MonoBehaviour {
    [SerializeField] public global::UnityEngine.Transform m_Content /* UnityEngine.Transform */;
    [SerializeField] public global::Kingmaker.UI.ServiceWindow.Encyclopedia.Blocks.EncyclopediaBlockRootPage m_RootPage /* Kingmaker.UI.ServiceWindow.Encyclopedia.Blocks.EncyclopediaBlockRootPage */;
    [SerializeField] public global::System.Collections.Generic.List<global::Kingmaker.UI.ServiceWindow.Encyclopedia.Blocks.EncyclopediaBlock> m_SourceBlocks /* System.Collections.Generic.List<Kingmaker.UI.ServiceWindow.Encyclopedia.Blocks.EncyclopediaBlock> */;
    [SerializeField] public global::Kingmaker.UI.Common.ScrollRectExtended m_ScrollView /* Kingmaker.UI.Common.ScrollRectExtended */;
}

}

