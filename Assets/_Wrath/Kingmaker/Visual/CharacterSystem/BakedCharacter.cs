using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.Visual.CharacterSystem {

public class BakedCharacter : global::UnityEngine.ScriptableObject {
    public global::System.Collections.Generic.List<global::Kingmaker.Visual.CharacterSystem.BakedCharacter.RendererDescription> RendererDescriptions /* System.Collections.Generic.List<Kingmaker.Visual.CharacterSystem.RendererDescription> */;

    public class RendererDescription {
        public string Name /* System.String */;
        public string[] Bones /* System.String[] */;
        public string RootBone /* System.String */;
        public global::UnityEngine.Mesh Mesh /* UnityEngine.Mesh */;
        public global::UnityEngine.Material Material /* UnityEngine.Material */;
        public object Textures /* System.Collections.Generic.List */;
    }

}

}

