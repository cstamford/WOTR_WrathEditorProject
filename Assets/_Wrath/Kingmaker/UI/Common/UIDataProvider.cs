using UnityEngine;

namespace Kingmaker.UI.Common {

public class UIDataProvider : ScriptableObject {
    [SerializeField] public object m_DisplayName /* Kingmaker.Localization.LocalizedString */;
    [SerializeField] public object m_Description /* Kingmaker.Localization.LocalizedString */;
    [SerializeField] public Sprite m_Icon /* UnityEngine.Sprite */;
}

}

