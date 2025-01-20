using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.LoadingScreen {

public class LoadingScreen : global::UnityEngine.MonoBehaviour {
    public global::Kingmaker.UI.LoadingScreen.LoadingScreenHints Hints /* Kingmaker.UI.LoadingScreen.LoadingScreenHints */;
    public object Hint /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::System.Collections.Generic.List<global::UnityEngine.UI.Image> m_Points /* System.Collections.Generic.List<UnityEngine.UI.Image> */;
    public global::UnityEngine.GameObject MapContainer /* UnityEngine.GameObject */;
    public global::UnityEngine.UI.Image Picture /* UnityEngine.UI.Image */;
    public global::UnityEngine.Sprite TempLoadingPicture /* UnityEngine.Sprite */;
    public global::System.Collections.Generic.List<global::Kingmaker.UI.LoadingScreen.LoadingScreen.SettingTypeScreens> SettingTypeScreensList /* System.Collections.Generic.List<Kingmaker.UI.LoadingScreen.SettingTypeScreens> */;
    public global::UnityEngine.UI.Image CharacterPortrait /* UnityEngine.UI.Image */;
    public object CharacterNameText /* TMPro.TextMeshProUGUI */;
    public object CharacterDesctiptionText /* TMPro.TextMeshProUGUI */;
    public float FadeTime /* System.Single */;
    public float LoadingDissolveTime /* System.Single */;
    public float HidingDissolveTime /* System.Single */;
    public float MinDissolveStep /* System.Single */;
    public float MaxDissolveStep /* System.Single */;
    public float HidingMaxDissolveStep /* System.Single */;

    public class SettingTypeScreens {
        public object Type /* Kingmaker.Blueprints.Area.SettingType */;
        public global::System.Collections.Generic.List<global::UnityEngine.Sprite> Sprites /* System.Collections.Generic.List<UnityEngine.Sprite> */;
    }

}

}

