using System;
using UnityEngine;

public class AkWindowsSettings {
    public object UserSettings /* .AkCommonUserSettings */;
    public AkWindowsSettings.PlatformAdvancedSettings AdvancedSettings /* .PlatformAdvancedSettings */;
    public object CommsSettings /* .AkCommonCommSettings */;

    public class PlatformAdvancedSettings {
        public AkWindowsSettings.PlatformAdvancedSettings.AudioAPI m_AudioAPI /* .AudioAPI */;
        public bool m_GlobalFocus /* System.Boolean */;

        public enum AudioAPI {
            Default = 0,
            None = 1,
            Wasapi = 2,
            XAudio2 = 4,
            DirectSound = -1,
        }

    }

}

