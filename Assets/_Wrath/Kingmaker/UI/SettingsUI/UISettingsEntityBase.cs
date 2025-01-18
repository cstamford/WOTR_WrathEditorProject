using System;
using UnityEngine;

namespace Kingmaker.UI.SettingsUI {

public class UISettingsEntityBase : ScriptableObject {
    [SerializeField] public object m_Description /* Kingmaker.Localization.LocalizedString */;
    [SerializeField] public object m_TooltipDescription /* Kingmaker.Localization.LocalizedString */;
    [SerializeField] public bool m_ShowVisualConnection /* System.Boolean */;
    [SerializeField] public bool m_IAmSetHandler /* System.Boolean */;
    [SerializeField] public UISettingsEntityBase.UISettingsPlatform m_SettingsPlatform /* Kingmaker.UI.SettingsUI.UISettingsPlatform */;

    public enum UISettingsPlatform {
        Everywhere = 0,
        PC = 1,
        Console = 2,
    }

}

}

