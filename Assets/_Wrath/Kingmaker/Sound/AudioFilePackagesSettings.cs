using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.Sound {

public class AudioFilePackagesSettings : global::UnityEngine.ScriptableObject {
    [SerializeField] public global::System.Collections.Generic.List<global::Kingmaker.Sound.AudioFilePackagesSettings.Mapping> m_PackageMapping /* System.Collections.Generic.List<Kingmaker.Sound.Mapping> */;
    [SerializeField] public global::System.Collections.Generic.List<global::Kingmaker.Sound.AudioFilePackagesSettings.Mapping> m_BankMapping /* System.Collections.Generic.List<Kingmaker.Sound.Mapping> */;

    public enum AudioChunk {
        Preload = 0,
        MainGame = 1,
        DLC1 = 2,
        DLC2 = 3,
        DLC3 = 4,
        DLC4 = 5,
        DLC5 = 6,
        DLC6 = 7,
    }

    public class Mapping {
        [SerializeField] public global::System.Collections.Generic.List<string> Values /* System.Collections.Generic.List<System.String> */;
    }

}

}

