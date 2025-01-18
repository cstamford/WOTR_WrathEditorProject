using System;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UI.Extensions {

public class AutoCompleteComboBox : MonoBehaviour {
    public Color disabledTextColor /* UnityEngine.Color */;
    public List<string> AvailableOptions /* System.Collections.Generic.List<System.String> */;
    [SerializeField] public float _scrollBarWidth /* System.Single */;
    [SerializeField] public int _itemsToDisplay /* System.Int32 */;
}

}

