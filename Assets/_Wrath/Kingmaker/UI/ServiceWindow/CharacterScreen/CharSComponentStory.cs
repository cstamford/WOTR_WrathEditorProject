using Kingmaker.UI.Common.Animations;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.ServiceWindow.CharacterScreen {

public class CharSComponentStory : global::UnityEngine.MonoBehaviour {
    public global::UnityEngine.RectTransform MainBox /* UnityEngine.RectTransform */;
    public global::UnityEngine.Vector2 BoxMinSize /* UnityEngine.Vector2 */;
    public global::UnityEngine.Vector2 BoxMaxSize /* UnityEngine.Vector2 */;
    public global::UnityEngine.RectTransform PictureBox /* UnityEngine.RectTransform */;
    public global::UnityEngine.Vector2 PictureMinSize /* UnityEngine.Vector2 */;
    public global::UnityEngine.Vector2 PictureMaxSize /* UnityEngine.Vector2 */;
    public global::UnityEngine.GameObject TextBoxAnimator /* UnityEngine.GameObject */;
    public global::UnityEngine.UI.Image MainPicture /* UnityEngine.UI.Image */;
    public object TitlePicture /* TMPro.TextMeshProUGUI */;
    public global::UnityEngine.GameObject TitlePictureContainer /* UnityEngine.GameObject */;
    public object TitleStory /* TMPro.TextMeshProUGUI */;
    public object StoryText /* TMPro.TextMeshProUGUI */;
    public global::UnityEngine.GameObject Story /* UnityEngine.GameObject */;
    public global::UnityEngine.UI.Button BackButton /* UnityEngine.UI.Button */;
    public global::UnityEngine.UI.Button MainPictureTrigger /* UnityEngine.UI.Button */;
    public global::UnityEngine.GameObject Placeholder /* UnityEngine.GameObject */;
    public object PlaceholderTitle /* TMPro.TextMeshProUGUI */;
    public global::Kingmaker.UI.ServiceWindow.CharacterScreen.CharSComponentStory.Mode BoxMode /* Kingmaker.UI.ServiceWindow.CharacterScreen.Mode */;
    public global::Kingmaker.UI.Common.Animations.FadeAnimator FadeAnimator /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    public global::UnityEngine.Sprite DefaultImage /* UnityEngine.Sprite */;

    public enum Mode {
        Hidden = 0,
        Short = 1,
        Full = 2,
    }

}

}

