using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.LoadingScreen {

public class LoadingScreen : MonoBehaviour {
    public object Hints /* Kingmaker.UI.LoadingScreen.LoadingScreenHints */;
    public object Hint /* TMPro.TextMeshProUGUI */;
    [SerializeField] public List<Image> m_Points /* System.Collections.Generic.List<UnityEngine.UI.Image> */;
    public GameObject MapContainer /* UnityEngine.GameObject */;
    public Image Picture /* UnityEngine.UI.Image */;
    public Sprite TempLoadingPicture /* UnityEngine.Sprite */;
    public List<LoadingScreen.SettingTypeScreens> SettingTypeScreensList /* System.Collections.Generic.List<Kingmaker.UI.LoadingScreen.SettingTypeScreens> */;
    public Image CharacterPortrait /* UnityEngine.UI.Image */;
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
        public List<Sprite> Sprites /* System.Collections.Generic.List<UnityEngine.Sprite> */;
    }

}

}

