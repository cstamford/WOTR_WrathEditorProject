using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.Visual.Particles {

public class MirrorImageFX : global::UnityEngine.MonoBehaviour {
    [SerializeField] public global::System.Collections.Generic.List<global::Kingmaker.Visual.Particles.MirrorImageFX.MirrorImageEntry> m_Entries /* System.Collections.Generic.List<Kingmaker.Visual.Particles.MirrorImageEntry> */;

    public class MirrorImageEntry {
        public int ImageIndex /* System.Int32 */;
        public global::UnityEngine.GameObject MainFxPrefab /* UnityEngine.GameObject */;
        public global::UnityEngine.GameObject DeathFxPrefab /* UnityEngine.GameObject */;
        public global::UnityEngine.Vector3 Offset /* UnityEngine.Vector3 */;
    }

}

}

