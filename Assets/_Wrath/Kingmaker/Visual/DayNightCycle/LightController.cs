using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

namespace Kingmaker.Visual.DayNightCycle {

public class LightController {
    public object EditorTimeOfDay /* Kingmaker.AreaLogic.TimeOfDay */;
    public global::System.Collections.Generic.List<global::UnityEngine.Light> LightsForEdit /* System.Collections.Generic.List<UnityEngine.Light> */;
    public global::Kingmaker.Visual.DayNightCycle.LightController.CameraLightInitStatus CameraLight /* Kingmaker.Visual.DayNightCycle.CameraLightInitStatus */;
    public global::UnityEngine.CameraClearFlags CameraClearFlag /* UnityEngine.CameraClearFlags */;
    public global::UnityEngine.Light MainLight /* UnityEngine.Light */;
    [SerializeField] public global::Kingmaker.Visual.DayNightCycle.SceneLightConfig m_SoloConfig /* Kingmaker.Visual.DayNightCycle.SceneLightConfig */;
    [SerializeField] public global::Kingmaker.Visual.DayNightCycle.SceneLightConfig m_MorningConfig /* Kingmaker.Visual.DayNightCycle.SceneLightConfig */;
    [SerializeField] public global::Kingmaker.Visual.DayNightCycle.SceneLightConfig m_DayConfig /* Kingmaker.Visual.DayNightCycle.SceneLightConfig */;
    [SerializeField] public global::Kingmaker.Visual.DayNightCycle.SceneLightConfig m_EveningConfig /* Kingmaker.Visual.DayNightCycle.SceneLightConfig */;
    [SerializeField] public global::Kingmaker.Visual.DayNightCycle.SceneLightConfig m_NightConfig /* Kingmaker.Visual.DayNightCycle.SceneLightConfig */;
    [SerializeField] public global::System.Collections.Generic.List<global::UnityEngine.ReflectionProbe> m_ReflectionProbes /* System.Collections.Generic.List<UnityEngine.ReflectionProbe> */;
    [SerializeField] public global::System.Collections.Generic.List<global::UnityEngine.Rendering.Volume> m_SoloPostProcessingVolumes /* System.Collections.Generic.List<UnityEngine.Rendering.Volume> */;
    [SerializeField] public global::System.Collections.Generic.List<global::UnityEngine.Rendering.Volume> m_MorningPostProcessingVolumes /* System.Collections.Generic.List<UnityEngine.Rendering.Volume> */;
    [SerializeField] public global::System.Collections.Generic.List<global::UnityEngine.Rendering.Volume> m_DayPostProcessingVolumes /* System.Collections.Generic.List<UnityEngine.Rendering.Volume> */;
    [SerializeField] public global::System.Collections.Generic.List<global::UnityEngine.Rendering.Volume> m_EveningPostProcessingVolumes /* System.Collections.Generic.List<UnityEngine.Rendering.Volume> */;
    [SerializeField] public global::System.Collections.Generic.List<global::UnityEngine.Rendering.Volume> m_NightPostProcessingVolumes /* System.Collections.Generic.List<UnityEngine.Rendering.Volume> */;
    [SerializeField] public global::System.Collections.Generic.List<global::Kingmaker.Visual.DayNightCycle.LightController.LocalLightSettings> m_LocalLights /* System.Collections.Generic.List<Kingmaker.Visual.DayNightCycle.LocalLightSettings> */;
    [SerializeField] public global::System.Collections.Generic.List<global::Kingmaker.Visual.DayNightCycle.LightController.LocalObjectsSettings> m_LocalObjects /* System.Collections.Generic.List<Kingmaker.Visual.DayNightCycle.LocalObjectsSettings> */;

    public class LocalLightSettings {
        public global::UnityEngine.Light Light /* UnityEngine.Light */;
        public global::Kingmaker.Visual.DayNightCycle.LightController.LightConfig MorningConfig /* Kingmaker.Visual.DayNightCycle.LightConfig */;
        public global::Kingmaker.Visual.DayNightCycle.LightController.LightConfig DayConfig /* Kingmaker.Visual.DayNightCycle.LightConfig */;
        public global::Kingmaker.Visual.DayNightCycle.LightController.LightConfig EveningConfig /* Kingmaker.Visual.DayNightCycle.LightConfig */;
        public global::Kingmaker.Visual.DayNightCycle.LightController.LightConfig NightConfig /* Kingmaker.Visual.DayNightCycle.LightConfig */;
    }

    public class LocalObjectsSettings {
        public global::UnityEngine.GameObject Obj /* UnityEngine.GameObject */;
        public global::Kingmaker.Visual.DayNightCycle.LightController.ObjectConfig MorningConfig /* Kingmaker.Visual.DayNightCycle.ObjectConfig */;
        public global::Kingmaker.Visual.DayNightCycle.LightController.ObjectConfig DayConfig /* Kingmaker.Visual.DayNightCycle.ObjectConfig */;
        public global::Kingmaker.Visual.DayNightCycle.LightController.ObjectConfig EveningConfig /* Kingmaker.Visual.DayNightCycle.ObjectConfig */;
        public global::Kingmaker.Visual.DayNightCycle.LightController.ObjectConfig NightConfig /* Kingmaker.Visual.DayNightCycle.ObjectConfig */;
    }

    public class LightConfig {
        public float intensity /* System.Single */;
        public global::UnityEngine.Color color /* UnityEngine.Color */;
        public bool enabled /* System.Boolean */;
    }

    public class ObjectConfig {
        public bool enabled /* System.Boolean */;
    }

    public enum CameraLightInitStatus {
        notinit = 0,
        enabled = 1,
        disabled = 2,
    }

}

}

