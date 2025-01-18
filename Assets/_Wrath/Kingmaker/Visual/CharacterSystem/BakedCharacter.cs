using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.Visual.CharacterSystem {

public class BakedCharacter : ScriptableObject {
    public List<BakedCharacter.RendererDescription> RendererDescriptions /* System.Collections.Generic.List<Kingmaker.Visual.CharacterSystem.RendererDescription> */;

    public class RendererDescription {
        public string Name /* System.String */;
        public string[] Bones /* System.String[] */;
        public string RootBone /* System.String */;
        public Mesh Mesh /* UnityEngine.Mesh */;
        public Material Material /* UnityEngine.Material */;
        public object Textures /* System.Collections.Generic.List */;
    }

}

}

