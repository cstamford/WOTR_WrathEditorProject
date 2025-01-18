using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.UI.ActionBar {

public class ActionBarGroup : MonoBehaviour {
    public List<ActionBarGroupElement> GroupElements /* System.Collections.Generic.List<Kingmaker.UI.ActionBar.ActionBarGroupElement> */;
    public ActionBarSlots BarSlots /* Kingmaker.UI.ActionBar.ActionBarSlots */;
    [SerializeField] public int m_ShowPositionY /* System.Int32 */;
    [SerializeField] public int m_HidePositionY /* System.Int32 */;
}

}

