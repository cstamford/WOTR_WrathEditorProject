using System;
using UnityEngine;

namespace Kingmaker.UI.SettingsUI {

public class UISettingsEntityDropdownLocale {
    [SerializeField] public object m_ReplaceStrForNoConsole /* Kingmaker.UI.SettingsUI.ReplaceString[] */;
    [SerializeField] public object m_LocalizationDescription /* Kingmaker.Localization.LocalizedString[] */;

    public class ReplaceString {
        public string FromStr /* System.String */;
        public string ToStr /* System.String */;
    }

}

}

