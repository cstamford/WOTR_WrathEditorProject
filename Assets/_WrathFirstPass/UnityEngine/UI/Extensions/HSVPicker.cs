using System;
using UnityEngine;
using UnityEngine.UI;

namespace UnityEngine.UI.Extensions {

public class HSVPicker : MonoBehaviour {
    public HexRGB hexrgb /* UnityEngine.UI.Extensions.HexRGB */;
    public Color currentColor /* UnityEngine.Color */;
    public Image colorImage /* UnityEngine.UI.Image */;
    public Image pointer /* UnityEngine.UI.Image */;
    public Image cursor /* UnityEngine.UI.Image */;
    public RawImage hsvSlider /* UnityEngine.UI.RawImage */;
    public RawImage hsvImage /* UnityEngine.UI.RawImage */;
    public Slider sliderR /* UnityEngine.UI.Slider */;
    public Slider sliderG /* UnityEngine.UI.Slider */;
    public Slider sliderB /* UnityEngine.UI.Slider */;
    public Text sliderRText /* UnityEngine.UI.Text */;
    public Text sliderGText /* UnityEngine.UI.Text */;
    public Text sliderBText /* UnityEngine.UI.Text */;
    public float pointerPos /* System.Single */;
    public float cursorX /* System.Single */;
    public float cursorY /* System.Single */;
}

}

