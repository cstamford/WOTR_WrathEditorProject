using System;
using System.Collections.Generic;
using UnityEngine;

public class AkWwiseInitializationSettings {
    public global::System.Collections.Generic.List<string> PlatformSettingsNameList /* System.Collections.Generic.List<System.String> */;
    public global::System.Collections.Generic.List<AkWwiseInitializationSettings.PlatformSettings> PlatformSettingsList /* System.Collections.Generic.List<.PlatformSettings> */;
    public global::System.Collections.Generic.List<string> InvalidReferencePlatforms /* System.Collections.Generic.List<System.String> */;
    public object UserSettings /* .AkCommonUserSettings */;
    public object AdvancedSettings /* .AkCommonAdvancedSettings */;
    public object CommsSettings /* .AkCommonCommSettings */;

    public class PlatformSettings {
        [SerializeField] public global::System.Collections.Generic.List<string> IgnorePropertyNameList /* System.Collections.Generic.List<System.String> */;
        [SerializeField] public global::System.Collections.Generic.List<string> GlobalPropertyNameList /* System.Collections.Generic.List<System.String> */;
    }

    public class CommonPlatformSettings {
        public object UserSettings /* .AkCommonUserSettings */;
        public object AdvancedSettings /* .AkCommonAdvancedSettings */;
        public object CommsSettings /* .AkCommonCommSettings */;
    }

}

