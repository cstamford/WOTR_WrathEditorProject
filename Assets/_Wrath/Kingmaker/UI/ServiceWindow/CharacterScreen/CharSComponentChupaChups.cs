using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.ServiceWindow.CharacterScreen {

public class CharSComponentChupaChups : MonoBehaviour {
    public string Name /* System.String */;
    public Image RankBg /* UnityEngine.UI.Image */;
    public Image RankDark /* UnityEngine.UI.Image */;
    public Image Dark /* UnityEngine.UI.Image */;
    public object Rank /* TMPro.TextMeshProUGUI */;
    public Image Line /* UnityEngine.UI.Image */;
    public Sprite m_TwoDotsLine /* UnityEngine.Sprite */;
    public Sprite m_Dot /* UnityEngine.Sprite */;
    public float FutureAlpha /* System.Single */;
    public float DisableAlpha /* System.Single */;
    public Color DefaultBackgroundColor /* UnityEngine.Color */;
    public Image Background /* UnityEngine.UI.Image */;
    public Image Icon /* UnityEngine.UI.Image */;
    public RectTransform IconPlace /* UnityEngine.RectTransform */;
    public Image MaskImage /* UnityEngine.UI.Image */;
    public Mask MaskComponent /* UnityEngine.UI.Mask */;
    public CharSComponentChupaChups.Sizes Size /* Kingmaker.UI.ServiceWindow.CharacterScreen.Sizes */;
    public int BigSize /* System.Int32 */;
    public int NormalSize /* System.Int32 */;
    public int SmallSize /* System.Int32 */;
    public int ConnectorHeight /* System.Int32 */;
    public Vector2 ParentContainerSize /* UnityEngine.Vector2 */;
    public object AbilityAbbreviation /* TMPro.TextMeshProUGUI */;
    public Image RoundBorder /* UnityEngine.UI.Image */;
    public Image SquareBorder /* UnityEngine.UI.Image */;
    public int MLevel /* System.Int32 */;
    public int PrevLevel /* System.Int32 */;

    public enum Sizes {
        Small = 0,
        Normal = 1,
        Big = 2,
    }

}

}

