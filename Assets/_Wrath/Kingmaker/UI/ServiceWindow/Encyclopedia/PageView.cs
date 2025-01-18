using Kingmaker.UI.ServiceWindow.Encyclopedia.Blocks;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.UI.ServiceWindow.Encyclopedia {

public class PageView : MonoBehaviour {
    [SerializeField] public Transform m_Content /* UnityEngine.Transform */;
    [SerializeField] public object m_RootPage /* Kingmaker.UI.ServiceWindow.Encyclopedia.Blocks.EncyclopediaBlockRootPage */;
    [SerializeField] public List<EncyclopediaBlock> m_SourceBlocks /* System.Collections.Generic.List<Kingmaker.UI.ServiceWindow.Encyclopedia.Blocks.EncyclopediaBlock> */;
    [SerializeField] public object m_ScrollView /* Kingmaker.UI.Common.ScrollRectExtended */;
}

}

