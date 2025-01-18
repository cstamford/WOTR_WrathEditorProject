using UnityEngine;

namespace Kingmaker.UI.SettingsUI {

public class UISettingsGroup : ScriptableObject {
    public object Title /* Kingmaker.Localization.LocalizedString */;
    public object SettingsList /* Kingmaker.UI.SettingsUI.UISettingsEntityBase[] */;
}

}

