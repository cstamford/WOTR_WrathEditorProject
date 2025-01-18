using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.MVVM._ConsoleView.PhotoMode {

public class PhotoModeIconView : MonoBehaviour {
    [SerializeField] public Image Image /* UnityEngine.UI.Image */;
    [SerializeField] public GameObject m_ActivatingGO /* UnityEngine.GameObject */;
    [SerializeField] public RectTransform IconRectTransform /* UnityEngine.RectTransform */;
    [SerializeField] public Vector2 m_StartPos /* UnityEngine.Vector2 */;
    public float Scale /* System.Single */;
    public float XValue /* System.Single */;
    public float YValue /* System.Single */;
    public float CurrentRotation /* System.Single */;
}

}

