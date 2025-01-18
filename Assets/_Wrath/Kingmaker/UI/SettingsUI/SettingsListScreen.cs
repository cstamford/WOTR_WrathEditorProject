using System;
using UnityEngine;

namespace Kingmaker.UI.SettingsUI {

public class SettingsListScreen : MonoBehaviour {
    public object ScrollView /* Kingmaker.UI.Common.ScrollRectExtended */;
    public GameObject GroupContainer /* UnityEngine.GameObject */;
    public object SettingsItemPrefab /* Kingmaker.UI.SettingsUI.SettingsListItemGeneral */;
    public SettingsListHeader SettingsHeaderPrefab /* Kingmaker.UI.SettingsUI.SettingsListHeader */;
    public object SettingsSeparatorPrefab /* Kingmaker.UI.SettingsUI.SettingsListSeparator */;
    public object CurrentScreenSettings /* System.Nullable */;
    public bool IgnoreOnChange /* System.Boolean */;
}

}

