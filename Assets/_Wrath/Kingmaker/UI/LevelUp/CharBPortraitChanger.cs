using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.LevelUp {

public class CharBPortraitChanger : global::UnityEngine.MonoBehaviour {
    [SerializeField] public global::Kingmaker.UI.LevelUp.CharBPortraitChanger.FXedPortrait m_Portrait1 /* Kingmaker.UI.LevelUp.FXedPortrait */;
    [SerializeField] public global::Kingmaker.UI.LevelUp.CharBPortraitChanger.FXedPortrait m_Portrait2 /* Kingmaker.UI.LevelUp.FXedPortrait */;
    [SerializeField] public float m_AnimationSpeed /* System.Single */;

    public class FXedPortrait {
        public global::UnityEngine.UI.Image Portrait /* UnityEngine.UI.Image */;
        public _2dxFX_DesintegrationFX PortraitFx /* ._2dxFX_DesintegrationFX */;
    }

}

}

