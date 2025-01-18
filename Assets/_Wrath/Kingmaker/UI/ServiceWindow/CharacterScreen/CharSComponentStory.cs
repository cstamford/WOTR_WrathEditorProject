using Kingmaker.UI.Common.Animations;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.ServiceWindow.CharacterScreen {

public class CharSComponentStory : MonoBehaviour {
    public RectTransform MainBox /* UnityEngine.RectTransform */;
    public Vector2 BoxMinSize /* UnityEngine.Vector2 */;
    public Vector2 BoxMaxSize /* UnityEngine.Vector2 */;
    public RectTransform PictureBox /* UnityEngine.RectTransform */;
    public Vector2 PictureMinSize /* UnityEngine.Vector2 */;
    public Vector2 PictureMaxSize /* UnityEngine.Vector2 */;
    public GameObject TextBoxAnimator /* UnityEngine.GameObject */;
    public Image MainPicture /* UnityEngine.UI.Image */;
    public object TitlePicture /* TMPro.TextMeshProUGUI */;
    public GameObject TitlePictureContainer /* UnityEngine.GameObject */;
    public object TitleStory /* TMPro.TextMeshProUGUI */;
    public object StoryText /* TMPro.TextMeshProUGUI */;
    public GameObject Story /* UnityEngine.GameObject */;
    public Button BackButton /* UnityEngine.UI.Button */;
    public Button MainPictureTrigger /* UnityEngine.UI.Button */;
    public GameObject Placeholder /* UnityEngine.GameObject */;
    public object PlaceholderTitle /* TMPro.TextMeshProUGUI */;
    public CharSComponentStory.Mode BoxMode /* Kingmaker.UI.ServiceWindow.CharacterScreen.Mode */;
    public FadeAnimator FadeAnimator /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    public Sprite DefaultImage /* UnityEngine.Sprite */;

    public enum Mode {
        Hidden = 0,
        Short = 1,
        Full = 2,
    }

}

}

