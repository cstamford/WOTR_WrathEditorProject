using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.Visual.CharacterSystem.Dismemberment {

public class DismembermentTemplate : global::UnityEngine.ScriptableObject {
    public global::System.Collections.Generic.List<global::Kingmaker.Visual.CharacterSystem.Dismemberment.DismembermentTemplate.DismembermentTemplateSet> Sets /* System.Collections.Generic.List<Kingmaker.Visual.CharacterSystem.Dismemberment.DismembermentTemplateSet> */;

    public class DismembermentTemplateBone {
        public string TransformName /* System.String */;
        public float SliceOffset /* System.Single */;
        public global::UnityEngine.Vector3 SliceOrientationEuler /* UnityEngine.Vector3 */;
    }

    public class DismembermentTemplateSet {
        public object Type /* Kingmaker.Visual.CharacterSystem.Dismemberment.DismembermentLimbsApartType */;
        public global::System.Collections.Generic.List<global::Kingmaker.Visual.CharacterSystem.Dismemberment.DismembermentTemplate.DismembermentTemplateBone> SliceBones /* System.Collections.Generic.List<Kingmaker.Visual.CharacterSystem.Dismemberment.DismembermentTemplateBone> */;
    }

}

}

