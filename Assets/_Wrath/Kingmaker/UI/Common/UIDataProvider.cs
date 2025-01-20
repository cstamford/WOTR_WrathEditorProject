using System;
using UnityEngine;

namespace Kingmaker.UI.Common {

public class UIDataProvider : global::UnityEngine.ScriptableObject {
    [SerializeField] public object m_DisplayName /* Kingmaker.Localization.LocalizedString */;
    [SerializeField] public object m_Description /* Kingmaker.Localization.LocalizedString */;
    [SerializeField] public global::UnityEngine.Sprite m_Icon /* UnityEngine.Sprite */;
}

}

