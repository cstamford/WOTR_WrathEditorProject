using Kingmaker.UI.Common;
using Kingmaker.UI.MVVM._ConsoleView.PhotoMode;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

namespace Kingmaker.UI.MVVM._PCView.PhotoMode {

public class PhotoModeBaseView {
    [SerializeField] public global::UnityEngine.RectTransform m_RectTransform /* UnityEngine.RectTransform */;
    [SerializeField] public global::UnityEngine.CanvasGroup m_CanvasGroup /* UnityEngine.CanvasGroup */;
    [SerializeField] public float m_HidePosX /* System.Single */;
    [SerializeField] public float m_ShowPosX /* System.Single */;
    [SerializeField] public global::UnityEngine.Transform m_MainPhotoModeWindow /* UnityEngine.Transform */;
    [SerializeField] public global::UnityEngine.GameObject m_FramesRoot /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.UI.Image m_FramesImage /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.GameObject m_IconsRoot /* UnityEngine.GameObject */;
    [SerializeField] public global::System.Collections.Generic.List<global::Kingmaker.UI.MVVM._ConsoleView.PhotoMode.PhotoModeIconView> m_IconsPlace /* System.Collections.Generic.List<Kingmaker.UI.MVVM._ConsoleView.PhotoMode.PhotoModeIconView> */;
    [SerializeField] public global::UnityEngine.GameObject m_StickersRoot /* UnityEngine.GameObject */;
    [SerializeField] public global::System.Collections.Generic.List<global::Kingmaker.UI.MVVM._ConsoleView.PhotoMode.PhotoModeIconView> m_StickerSelective /* System.Collections.Generic.List<Kingmaker.UI.MVVM._ConsoleView.PhotoMode.PhotoModeIconView> */;
    [SerializeField] public global::UnityEngine.Rendering.Volume m_Volume /* UnityEngine.Rendering.Volume */;
    [SerializeField] public global::Kingmaker.UI.Common.WidgetListMVVM m_WidgetList /* Kingmaker.UI.Common.WidgetListMVVM */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.PhotoMode.PhotoModeMenuSelectorConsoleView m_MenuSelector /* Kingmaker.UI.MVVM._ConsoleView.PhotoMode.PhotoModeMenuSelectorConsoleView */;
    [SerializeField] public global::UnityEngine.RectTransform m_LeftPanel /* UnityEngine.RectTransform */;
    [SerializeField] public global::UnityEngine.RectTransform m_RightPanel /* UnityEngine.RectTransform */;
    [SerializeField] public float m_HintsHidePosY /* System.Single */;
    [SerializeField] public float m_HintsShowPosY /* System.Single */;
    [SerializeField] public global::UnityEngine.RectTransform m_HintsRectTransform /* UnityEngine.RectTransform */;
    [SerializeField] public global::UnityEngine.Transform m_HintPlace /* UnityEngine.Transform */;
}

}

