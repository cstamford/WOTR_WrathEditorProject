using System;
using UnityEngine;

public class AkPellegrinoSettings {
    public object UserSettings /* .AkCommonUserSettings */;
    public AkPellegrinoSettings.PlatformAdvancedSettings AdvancedSettings /* .PlatformAdvancedSettings */;
    public object CommsSettings /* .AkCommonCommSettings */;

    public class PlatformAdvancedSettings {
        public uint NumAudioOut2Ports /* System.UInt32 */;
        public uint NumAudioOut2ObjectPorts /* System.UInt32 */;
        public bool HwCodecLowLatencyMode /* System.Boolean */;
        public bool VorbisHwAcceleration /* System.Boolean */;
    }

}

