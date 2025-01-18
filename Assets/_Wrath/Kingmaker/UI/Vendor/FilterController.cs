using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.Vendor {

public class FilterController : MonoBehaviour {
    public object DropdownMenu /* TMPro.TMP_Dropdown */;
    public object DropdownMenuLabel /* TMPro.TextMeshProUGUI */;
    public bool HideNotSortedState /* System.Boolean */;
    public bool Save /* System.Boolean */;
    public object CurrentFilter /* Kingmaker.UI.Common.FilterType */;
    public object CurrentSorter /* Kingmaker.UI.Common.SorterType */;
    [SerializeField] public Toggle m_FilterAll /* UnityEngine.UI.Toggle */;
    [SerializeField] public Toggle m_FilterWeapon /* UnityEngine.UI.Toggle */;
    [SerializeField] public Toggle m_FilterArmor /* UnityEngine.UI.Toggle */;
    [SerializeField] public Toggle m_FilterAccessory /* UnityEngine.UI.Toggle */;
    [SerializeField] public Toggle m_FilterUsable /* UnityEngine.UI.Toggle */;
    [SerializeField] public Toggle m_FilterNotable /* UnityEngine.UI.Toggle */;
    [SerializeField] public Toggle m_FilterNonUsabel /* UnityEngine.UI.Toggle */;
}

}

