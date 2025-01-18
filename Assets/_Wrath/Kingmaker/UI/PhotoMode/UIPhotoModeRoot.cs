using System;
using UnityEngine;

namespace Kingmaker.UI.PhotoMode {

public class UIPhotoModeRoot : ScriptableObject {
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
    [SerializeField] public UIPhotoModeRoot.UIPhotoModeList PhotoMode /* Kingmaker.UI.PhotoMode.UIPhotoModeList */;

    public class UIPhotoModeList {
        public object EnableFrame /* Kingmaker.UI.SettingsUI.UISettingsEntityBool */;
        public object Frames /* Kingmaker.UI.SettingsUI.UISettingsEntitySliderInt */;
        public object EnableIcons /* Kingmaker.UI.SettingsUI.UISettingsEntityBool */;
        public object Icons /* Kingmaker.UI.SettingsUI.UISettingsEntityDropdownInt */;
        public object SelectedIconEnable /* Kingmaker.UI.SettingsUI.UISettingsEntityBool */;
        public object IconsAlpha /* Kingmaker.UI.SettingsUI.UISettingsEntitySliderFloat */;
        public object IconsPlace /* Kingmaker.UI.SettingsUI.UISettingsEntitySliderInt */;
        public object IconX /* Kingmaker.UI.SettingsUI.UISettingsEntitySliderFloat */;
        public object IconY /* Kingmaker.UI.SettingsUI.UISettingsEntitySliderFloat */;
        public object IconsScale /* Kingmaker.UI.SettingsUI.UISettingsEntitySliderFloat */;
        public object EnableStickers /* Kingmaker.UI.SettingsUI.UISettingsEntityBool */;
        public object Stickers /* Kingmaker.UI.SettingsUI.UISettingsEntitySliderInt */;
        public object SelectedStickersEnable /* Kingmaker.UI.SettingsUI.UISettingsEntityBool */;
        public object StickersAlpha /* Kingmaker.UI.SettingsUI.UISettingsEntitySliderFloat */;
        public object StickersSelective /* Kingmaker.UI.SettingsUI.UISettingsEntitySliderInt */;
        public object StickerX /* Kingmaker.UI.SettingsUI.UISettingsEntitySliderFloat */;
        public object StickerY /* Kingmaker.UI.SettingsUI.UISettingsEntitySliderFloat */;
        public object StickerScale /* Kingmaker.UI.SettingsUI.UISettingsEntitySliderFloat */;
        public object StickerRotation /* Kingmaker.UI.SettingsUI.UISettingsEntitySliderFloat */;
        public object EnableVignette /* Kingmaker.UI.SettingsUI.UISettingsEntityBool */;
        public object PlacementX /* Kingmaker.UI.SettingsUI.UISettingsEntityVisualPerception */;
        public object PlacementY /* Kingmaker.UI.SettingsUI.UISettingsEntityVisualPerception */;
        public object VignetteIntensity /* Kingmaker.UI.SettingsUI.UISettingsEntityVisualPerception */;
        public object Smoothness /* Kingmaker.UI.SettingsUI.UISettingsEntityVisualPerception */;
        public object Rounded /* Kingmaker.UI.SettingsUI.UISettingsEntityBool */;
        public object EnableDepthOfField /* Kingmaker.UI.SettingsUI.UISettingsEntityBool */;
        public object FocusDistance /* Kingmaker.UI.SettingsUI.UISettingsEntitySliderInt */;
        public object FocalLength /* Kingmaker.UI.SettingsUI.UISettingsEntitySliderInt */;
        public object Aperture /* Kingmaker.UI.SettingsUI.UISettingsEntitySliderFloat */;
        public object GrainEnable /* Kingmaker.UI.SettingsUI.UISettingsEntityBool */;
        public object GrainType /* Kingmaker.UI.SettingsUI.UISettingsEntityDropdownInt */;
        public object GrainIntensity /* Kingmaker.UI.SettingsUI.UISettingsEntitySliderFloat */;
        public object PostExposure /* Kingmaker.UI.SettingsUI.UISettingsEntityVisualPerception */;
        public object Saturation /* Kingmaker.UI.SettingsUI.UISettingsEntityVisualPerception */;
        public object Contrast /* Kingmaker.UI.SettingsUI.UISettingsEntityVisualPerception */;
        public object Temperature /* Kingmaker.UI.SettingsUI.UISettingsEntityVisualPerception */;
        public object ChromaticAberration /* Kingmaker.UI.SettingsUI.UISettingsEntitySliderFloat */;
        public object Sepia /* Kingmaker.UI.SettingsUI.UISettingsEntitySliderFloat */;
        public object CameraRotationPhotoSpeedKeyboard /* Kingmaker.UI.SettingsUI.UISettingsEntitySliderFloat */;
        public object CameraRotationPhotoSpeedMouse /* Kingmaker.UI.SettingsUI.UISettingsEntitySliderFloat */;
        public object CameraMovePhotoSpeedGamepad /* Kingmaker.UI.SettingsUI.UISettingsEntitySliderFloat */;
        public object CameraRotationPhotoSpeedGamepad /* Kingmaker.UI.SettingsUI.UISettingsEntitySliderFloat */;
        public object CameraRotationBankPhotoSpeedGamepad /* Kingmaker.UI.SettingsUI.UISettingsEntitySliderFloat */;
        public object PhotoCameraUp /* Kingmaker.UI.SettingsUI.UISettingsEntityKeyBinding */;
        public object PhotoCameraDown /* Kingmaker.UI.SettingsUI.UISettingsEntityKeyBinding */;
        public object PhotoCameraLeftBank /* Kingmaker.UI.SettingsUI.UISettingsEntityKeyBinding */;
        public object PhotoCameraRightBank /* Kingmaker.UI.SettingsUI.UISettingsEntityKeyBinding */;
        public object PhotoCameraResetBank /* Kingmaker.UI.SettingsUI.UISettingsEntityKeyBinding */;
        public object PhotoHideIU /* Kingmaker.UI.SettingsUI.UISettingsEntityKeyBinding */;
        public object PhotoHideHUD /* Kingmaker.UI.SettingsUI.UISettingsEntityKeyBinding */;
        public object PhotoLeftPage /* Kingmaker.UI.SettingsUI.UISettingsEntityKeyBinding */;
        public object PhotoRightPage /* Kingmaker.UI.SettingsUI.UISettingsEntityKeyBinding */;
        public object SkyBoxEnable /* Kingmaker.UI.SettingsUI.UISettingsEntityBool */;
        public object SkyBoxes /* Kingmaker.UI.SettingsUI.UISettingsEntitySliderInt */;
        public object WeatherEnable /* Kingmaker.UI.SettingsUI.UISettingsEntityBool */;
        public object Weather /* Kingmaker.UI.SettingsUI.UISettingsEntitySliderInt */;
    }

}

}

