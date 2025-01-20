using System;
using UnityEngine;

public class AkXBoxOneSettings {
    public object UserSettings /* .AkCommonUserSettings */;
    public AkXBoxOneSettings.PlatformAdvancedSettings AdvancedSettings /* .PlatformAdvancedSettings */;
    public object CommsSettings /* .AkCommonCommSettings */;

    public class PlatformAdvancedSettings {
        public ushort MaximumNumberOfXMAVoices /* System.UInt16 */;
        public bool UseHardwareCodecLowLatencyMode /* System.Boolean */;
        public uint APUHeapCachedSize /* System.UInt32 */;
        public uint APUHeapNonCachedSize /* System.UInt32 */;
    }

}

