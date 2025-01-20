using System;
using UnityEngine;

public class AkPS4Settings {
    public object UserSettings /* .AkCommonUserSettings */;
    public AkPS4Settings.PlatformAdvancedSettings AdvancedSettings /* .PlatformAdvancedSettings */;
    public object CommsSettings /* .AkCommonCommSettings */;

    public class PlatformAdvancedSettings {
        public uint ACPBatchBufferSize /* System.UInt32 */;
        public bool UseHardwareCodecLowLatencyMode /* System.Boolean */;
    }

}

