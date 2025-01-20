using Kingmaker.UI.SettingsUI;
using System;
using UnityEngine;

namespace Kingmaker.UI.PhotoMode {

public class UIPhotoModeRoot : global::UnityEngine.ScriptableObject {
    public object FrameSettings /* Kingmaker.UI.SettingsUI.UISettingsGroup[] */;
    public object IconsSettings /* Kingmaker.UI.SettingsUI.UISettingsGroup[] */;
    public object StickersSettings /* Kingmaker.UI.SettingsUI.UISettingsGroup[] */;
    public object VignetteSettings /* Kingmaker.UI.SettingsUI.UISettingsGroup[] */;
    public object DepthOfFieldSettings /* Kingmaker.UI.SettingsUI.UISettingsGroup[] */;
    public object GrainSettings /* Kingmaker.UI.SettingsUI.UISettingsGroup[] */;
    public object OtherSettings /* Kingmaker.UI.SettingsUI.UISettingsGroup[] */;
    public object SkyBoxSettings /* Kingmaker.UI.SettingsUI.UISettingsGroup[] */;
    public object WeatherSettings /* Kingmaker.UI.SettingsUI.UISettingsGroup[] */;
    public object CameraSettings /* Kingmaker.UI.SettingsUI.UISettingsGroup[] */;
    [SerializeField] public global::Kingmaker.UI.PhotoMode.UIPhotoModeRoot.UIPhotoModeList PhotoMode /* Kingmaker.UI.PhotoMode.UIPhotoModeList */;

    public class UIPhotoModeList {
        public global::Kingmaker.UI.SettingsUI.UISettingsEntityBool EnableFrame /* Kingmaker.UI.SettingsUI.UISettingsEntityBool */;
        public global::Kingmaker.UI.SettingsUI.UISettingsEntitySliderInt Frames /* Kingmaker.UI.SettingsUI.UISettingsEntitySliderInt */;
        public global::Kingmaker.UI.SettingsUI.UISettingsEntityBool EnableIcons /* Kingmaker.UI.SettingsUI.UISettingsEntityBool */;
        public global::Kingmaker.UI.SettingsUI.UISettingsEntityDropdownInt Icons /* Kingmaker.UI.SettingsUI.UISettingsEntityDropdownInt */;
        public global::Kingmaker.UI.SettingsUI.UISettingsEntityBool SelectedIconEnable /* Kingmaker.UI.SettingsUI.UISettingsEntityBool */;
        public global::Kingmaker.UI.SettingsUI.UISettingsEntitySliderFloat IconsAlpha /* Kingmaker.UI.SettingsUI.UISettingsEntitySliderFloat */;
        public global::Kingmaker.UI.SettingsUI.UISettingsEntitySliderInt IconsPlace /* Kingmaker.UI.SettingsUI.UISettingsEntitySliderInt */;
        public global::Kingmaker.UI.SettingsUI.UISettingsEntitySliderFloat IconX /* Kingmaker.UI.SettingsUI.UISettingsEntitySliderFloat */;
        public global::Kingmaker.UI.SettingsUI.UISettingsEntitySliderFloat IconY /* Kingmaker.UI.SettingsUI.UISettingsEntitySliderFloat */;
        public global::Kingmaker.UI.SettingsUI.UISettingsEntitySliderFloat IconsScale /* Kingmaker.UI.SettingsUI.UISettingsEntitySliderFloat */;
        public global::Kingmaker.UI.SettingsUI.UISettingsEntityBool EnableStickers /* Kingmaker.UI.SettingsUI.UISettingsEntityBool */;
        public global::Kingmaker.UI.SettingsUI.UISettingsEntitySliderInt Stickers /* Kingmaker.UI.SettingsUI.UISettingsEntitySliderInt */;
        public global::Kingmaker.UI.SettingsUI.UISettingsEntityBool SelectedStickersEnable /* Kingmaker.UI.SettingsUI.UISettingsEntityBool */;
        public global::Kingmaker.UI.SettingsUI.UISettingsEntitySliderFloat StickersAlpha /* Kingmaker.UI.SettingsUI.UISettingsEntitySliderFloat */;
        public global::Kingmaker.UI.SettingsUI.UISettingsEntitySliderInt StickersSelective /* Kingmaker.UI.SettingsUI.UISettingsEntitySliderInt */;
        public global::Kingmaker.UI.SettingsUI.UISettingsEntitySliderFloat StickerX /* Kingmaker.UI.SettingsUI.UISettingsEntitySliderFloat */;
        public global::Kingmaker.UI.SettingsUI.UISettingsEntitySliderFloat StickerY /* Kingmaker.UI.SettingsUI.UISettingsEntitySliderFloat */;
        public global::Kingmaker.UI.SettingsUI.UISettingsEntitySliderFloat StickerScale /* Kingmaker.UI.SettingsUI.UISettingsEntitySliderFloat */;
        public global::Kingmaker.UI.SettingsUI.UISettingsEntitySliderFloat StickerRotation /* Kingmaker.UI.SettingsUI.UISettingsEntitySliderFloat */;
        public global::Kingmaker.UI.SettingsUI.UISettingsEntityBool EnableVignette /* Kingmaker.UI.SettingsUI.UISettingsEntityBool */;
        public global::Kingmaker.UI.SettingsUI.UISettingsEntityVisualPerception PlacementX /* Kingmaker.UI.SettingsUI.UISettingsEntityVisualPerception */;
        public global::Kingmaker.UI.SettingsUI.UISettingsEntityVisualPerception PlacementY /* Kingmaker.UI.SettingsUI.UISettingsEntityVisualPerception */;
        public global::Kingmaker.UI.SettingsUI.UISettingsEntityVisualPerception VignetteIntensity /* Kingmaker.UI.SettingsUI.UISettingsEntityVisualPerception */;
        public global::Kingmaker.UI.SettingsUI.UISettingsEntityVisualPerception Smoothness /* Kingmaker.UI.SettingsUI.UISettingsEntityVisualPerception */;
        public global::Kingmaker.UI.SettingsUI.UISettingsEntityBool Rounded /* Kingmaker.UI.SettingsUI.UISettingsEntityBool */;
        public global::Kingmaker.UI.SettingsUI.UISettingsEntityBool EnableDepthOfField /* Kingmaker.UI.SettingsUI.UISettingsEntityBool */;
        public global::Kingmaker.UI.SettingsUI.UISettingsEntitySliderInt FocusDistance /* Kingmaker.UI.SettingsUI.UISettingsEntitySliderInt */;
        public global::Kingmaker.UI.SettingsUI.UISettingsEntitySliderInt FocalLength /* Kingmaker.UI.SettingsUI.UISettingsEntitySliderInt */;
        public global::Kingmaker.UI.SettingsUI.UISettingsEntitySliderFloat Aperture /* Kingmaker.UI.SettingsUI.UISettingsEntitySliderFloat */;
        public global::Kingmaker.UI.SettingsUI.UISettingsEntityBool GrainEnable /* Kingmaker.UI.SettingsUI.UISettingsEntityBool */;
        public global::Kingmaker.UI.SettingsUI.UISettingsEntityDropdownInt GrainType /* Kingmaker.UI.SettingsUI.UISettingsEntityDropdownInt */;
        public global::Kingmaker.UI.SettingsUI.UISettingsEntitySliderFloat GrainIntensity /* Kingmaker.UI.SettingsUI.UISettingsEntitySliderFloat */;
        public global::Kingmaker.UI.SettingsUI.UISettingsEntityVisualPerception PostExposure /* Kingmaker.UI.SettingsUI.UISettingsEntityVisualPerception */;
        public global::Kingmaker.UI.SettingsUI.UISettingsEntityVisualPerception Saturation /* Kingmaker.UI.SettingsUI.UISettingsEntityVisualPerception */;
        public global::Kingmaker.UI.SettingsUI.UISettingsEntityVisualPerception Contrast /* Kingmaker.UI.SettingsUI.UISettingsEntityVisualPerception */;
        public global::Kingmaker.UI.SettingsUI.UISettingsEntityVisualPerception Temperature /* Kingmaker.UI.SettingsUI.UISettingsEntityVisualPerception */;
        public global::Kingmaker.UI.SettingsUI.UISettingsEntitySliderFloat ChromaticAberration /* Kingmaker.UI.SettingsUI.UISettingsEntitySliderFloat */;
        public global::Kingmaker.UI.SettingsUI.UISettingsEntitySliderFloat Sepia /* Kingmaker.UI.SettingsUI.UISettingsEntitySliderFloat */;
        public global::Kingmaker.UI.SettingsUI.UISettingsEntitySliderFloat CameraRotationPhotoSpeedKeyboard /* Kingmaker.UI.SettingsUI.UISettingsEntitySliderFloat */;
        public global::Kingmaker.UI.SettingsUI.UISettingsEntitySliderFloat CameraRotationPhotoSpeedMouse /* Kingmaker.UI.SettingsUI.UISettingsEntitySliderFloat */;
        public global::Kingmaker.UI.SettingsUI.UISettingsEntitySliderFloat CameraMovePhotoSpeedGamepad /* Kingmaker.UI.SettingsUI.UISettingsEntitySliderFloat */;
        public global::Kingmaker.UI.SettingsUI.UISettingsEntitySliderFloat CameraRotationPhotoSpeedGamepad /* Kingmaker.UI.SettingsUI.UISettingsEntitySliderFloat */;
        public global::Kingmaker.UI.SettingsUI.UISettingsEntitySliderFloat CameraRotationBankPhotoSpeedGamepad /* Kingmaker.UI.SettingsUI.UISettingsEntitySliderFloat */;
        public global::Kingmaker.UI.SettingsUI.UISettingsEntityKeyBinding PhotoCameraUp /* Kingmaker.UI.SettingsUI.UISettingsEntityKeyBinding */;
        public global::Kingmaker.UI.SettingsUI.UISettingsEntityKeyBinding PhotoCameraDown /* Kingmaker.UI.SettingsUI.UISettingsEntityKeyBinding */;
        public global::Kingmaker.UI.SettingsUI.UISettingsEntityKeyBinding PhotoCameraLeftBank /* Kingmaker.UI.SettingsUI.UISettingsEntityKeyBinding */;
        public global::Kingmaker.UI.SettingsUI.UISettingsEntityKeyBinding PhotoCameraRightBank /* Kingmaker.UI.SettingsUI.UISettingsEntityKeyBinding */;
        public global::Kingmaker.UI.SettingsUI.UISettingsEntityKeyBinding PhotoCameraResetBank /* Kingmaker.UI.SettingsUI.UISettingsEntityKeyBinding */;
        public global::Kingmaker.UI.SettingsUI.UISettingsEntityKeyBinding PhotoHideIU /* Kingmaker.UI.SettingsUI.UISettingsEntityKeyBinding */;
        public global::Kingmaker.UI.SettingsUI.UISettingsEntityKeyBinding PhotoHideHUD /* Kingmaker.UI.SettingsUI.UISettingsEntityKeyBinding */;
        public global::Kingmaker.UI.SettingsUI.UISettingsEntityKeyBinding PhotoLeftPage /* Kingmaker.UI.SettingsUI.UISettingsEntityKeyBinding */;
        public global::Kingmaker.UI.SettingsUI.UISettingsEntityKeyBinding PhotoRightPage /* Kingmaker.UI.SettingsUI.UISettingsEntityKeyBinding */;
        public global::Kingmaker.UI.SettingsUI.UISettingsEntityBool SkyBoxEnable /* Kingmaker.UI.SettingsUI.UISettingsEntityBool */;
        public global::Kingmaker.UI.SettingsUI.UISettingsEntitySliderInt SkyBoxes /* Kingmaker.UI.SettingsUI.UISettingsEntitySliderInt */;
        public global::Kingmaker.UI.SettingsUI.UISettingsEntityBool WeatherEnable /* Kingmaker.UI.SettingsUI.UISettingsEntityBool */;
        public global::Kingmaker.UI.SettingsUI.UISettingsEntitySliderInt Weather /* Kingmaker.UI.SettingsUI.UISettingsEntitySliderInt */;
    }

}

}

