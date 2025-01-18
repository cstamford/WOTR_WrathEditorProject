using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.Sound {

public class AudioFilePackagesSettings : ScriptableObject {
    [SerializeField] public List<AudioFilePackagesSettings.Mapping> m_PackageMapping /* System.Collections.Generic.List<Kingmaker.Sound.Mapping> */;
    [SerializeField] public List<AudioFilePackagesSettings.Mapping> m_BankMapping /* System.Collections.Generic.List<Kingmaker.Sound.Mapping> */;

    public class Mapping {
        [SerializeField] public List<string> Values /* System.Collections.Generic.List<System.String> */;
    }

}

}

