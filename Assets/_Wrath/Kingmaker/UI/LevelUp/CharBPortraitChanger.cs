using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.LevelUp {

public class CharBPortraitChanger : MonoBehaviour {
    [SerializeField] public CharBPortraitChanger.FXedPortrait m_Portrait1 /* Kingmaker.UI.LevelUp.FXedPortrait */;
    [SerializeField] public CharBPortraitChanger.FXedPortrait m_Portrait2 /* Kingmaker.UI.LevelUp.FXedPortrait */;
    [SerializeField] public float m_AnimationSpeed /* System.Single */;

    public class FXedPortrait {
        public Image Portrait /* UnityEngine.UI.Image */;
        public object PortraitFx /* ._2dxFX_DesintegrationFX */;
    }

}

}

