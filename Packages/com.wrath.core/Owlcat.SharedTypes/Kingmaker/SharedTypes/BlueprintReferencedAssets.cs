using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.SharedTypes {

public class BlueprintReferencedAssets : ScriptableObject {
    [SerializeField] public List<BlueprintReferencedAssets.Entry> m_Entries /* System.Collections.Generic.List<Kingmaker.SharedTypes.Entry> */;

    public struct Entry {
        public string AssetId /* System.String */;
        public long FileId /* System.Int64 */;
        public UnityEngine.Object Asset /* UnityEngine.Object */;
    }

}

}

