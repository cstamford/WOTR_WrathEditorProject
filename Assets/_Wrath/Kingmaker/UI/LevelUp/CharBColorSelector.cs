using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.LevelUp {

public class CharBColorSelector : global::UnityEngine.MonoBehaviour {
    [SerializeField] public object m_Label /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.UI.ToggleGroup m_ColorToggleGroup /* UnityEngine.UI.ToggleGroup */;
    [SerializeField] public global::UnityEngine.UI.Toggle m_ColorToggleItem /* UnityEngine.UI.Toggle */;
    public int CurrentElementIndex /* System.Int32 */;
}

}

