using System;
using UnityEngine;

namespace Kingmaker.Visual {

public class Billboard {
    public global::Kingmaker.Visual.Billboard.Axis BillboardAxis /* Kingmaker.Visual.Axis */;
    [SerializeField] public global::Kingmaker.Visual.Billboard.LockAxisSettings m_LockAxis /* Kingmaker.Visual.LockAxisSettings */;
    public bool ApplyAtFirstFrameOnly /* System.Boolean */;

    public enum Axis {
        NegativeX = 0,
        NegativeY = 1,
        PositiveZ = 2,
        PositiveX = 3,
        PositiveY = 4,
        NegativeZ = 5,
    }

    public class LockAxisSettings {
        public bool Enabled /* System.Boolean */;
        public global::UnityEngine.Vector3 Axis /* UnityEngine.Vector3 */;
        public global::UnityEngine.Space Space /* UnityEngine.Space */;
    }

}

}

