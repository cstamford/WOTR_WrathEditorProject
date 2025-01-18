using System;
using UnityEngine;

namespace Kingmaker.Visual.Sound {

public class SurfaceTypeData : ScriptableObject {
    public object Types /* Kingmaker.Visual.Sound.Entry[] */;
    public string[] SortedMaskNames /* System.String[] */;
    public object Settings /* Kingmaker.Visual.Sound.Setting[] */;
    [SerializeField] public object m_SurfaceDebugInfos /* Kingmaker.Visual.Sound.SurfaceDebugInfo[] */;

    public class Entry {
        public string SoundSwitch /* System.String */;
        public string[] MaskNames /* System.String[] */;
    }

    public class SurfaceDebugInfo {
        public object SoundSwitch /* Kingmaker.Sound.SurfaceSoundType */;
        public Color GizmoColor /* UnityEngine.Color */;
    }

    public class Setting {
        public object Type /* Kingmaker.Blueprints.Area.SettingType */;
        public string[] SortedMaskNames /* System.String[] */;
    }

}

}

