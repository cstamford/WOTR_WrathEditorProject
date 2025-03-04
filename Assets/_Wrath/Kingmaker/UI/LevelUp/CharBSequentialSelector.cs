using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.LevelUp {

public class CharBSequentialSelector : global::UnityEngine.MonoBehaviour {
    [SerializeField] public object m_Label /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_CurrentItemName /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_Counter /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.UI.Button m_BackButton /* UnityEngine.UI.Button */;
    [SerializeField] public global::UnityEngine.UI.Button m_NextButton /* UnityEngine.UI.Button */;
    [SerializeField] public bool m_Loop /* System.Boolean */;
}

}

