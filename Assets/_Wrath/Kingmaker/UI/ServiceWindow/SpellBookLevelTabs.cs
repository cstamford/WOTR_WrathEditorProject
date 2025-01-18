using Kingmaker.UI.Common;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.ServiceWindow {

public class SpellBookLevelTabs : MonoBehaviour {
    public ToggleGroup Group /* UnityEngine.UI.ToggleGroup */;
    public Toggle ToggleFavorites /* UnityEngine.UI.Toggle */;
    public int FavotiveToggleIndex /* System.Int32 */;
    public List<ExtendedToggleTab> m_Tabs /* System.Collections.Generic.List<Kingmaker.UI.Common.ExtendedToggleTab> */;
}

}

