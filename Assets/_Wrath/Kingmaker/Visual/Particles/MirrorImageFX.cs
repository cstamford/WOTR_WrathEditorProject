using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.Visual.Particles {

public class MirrorImageFX : MonoBehaviour {
    [SerializeField] public List<MirrorImageFX.MirrorImageEntry> m_Entries /* System.Collections.Generic.List<Kingmaker.Visual.Particles.MirrorImageEntry> */;

    public class MirrorImageEntry {
        public int ImageIndex /* System.Int32 */;
        public GameObject MainFxPrefab /* UnityEngine.GameObject */;
        public GameObject DeathFxPrefab /* UnityEngine.GameObject */;
        public Vector3 Offset /* UnityEngine.Vector3 */;
    }

}

}

