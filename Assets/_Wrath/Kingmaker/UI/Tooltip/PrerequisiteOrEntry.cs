using System;
using UnityEngine;

namespace Kingmaker.UI.Tooltip {

public class PrerequisiteOrEntry : global::UnityEngine.MonoBehaviour {
    [SerializeField] public object m_Text /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.GameObject m_Separator /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.Color32 m_DoneColor /* UnityEngine.Color32 */;
    [SerializeField] public global::UnityEngine.Color32 m_RequiredColor /* UnityEngine.Color32 */;
}

}

