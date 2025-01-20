using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.SaveLoadWindow {

public class RootSaveSlot : global::UnityEngine.MonoBehaviour {
    [SerializeField] public object m_Label /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_HighlightLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.Transform m_ExpandArrow /* UnityEngine.Transform */;
    public global::UnityEngine.GameObject[] m_HighlightObjects /* UnityEngine.GameObject[] */;
    [SerializeField] public global::UnityEngine.UI.Button m_Button /* UnityEngine.UI.Button */;
}

}

