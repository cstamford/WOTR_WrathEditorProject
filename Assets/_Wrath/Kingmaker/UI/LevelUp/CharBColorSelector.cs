using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.LevelUp {

public class CharBColorSelector : MonoBehaviour {
    [SerializeField] public object m_Label /* TMPro.TextMeshProUGUI */;
    [SerializeField] public ToggleGroup m_ColorToggleGroup /* UnityEngine.UI.ToggleGroup */;
    [SerializeField] public Toggle m_ColorToggleItem /* UnityEngine.UI.Toggle */;
    public int CurrentElementIndex /* System.Int32 */;
}

}

