using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.Visual.CharacterSystem {

public class RampColorPreset : global::UnityEngine.ScriptableObject {
    [SerializeField] public global::System.Collections.Generic.List<global::Kingmaker.Visual.CharacterSystem.RampColorPreset.IndexSet> IndexPairs /* System.Collections.Generic.List<Kingmaker.Visual.CharacterSystem.IndexSet> */;
    public int PrimaryIndex /* System.Int32 */;
    public int SecondaryIndex /* System.Int32 */;

    public class IndexSet {
        [SerializeField] public string Name /* System.String */;
        [SerializeField] public int PrimaryIndex /* System.Int32 */;
        [SerializeField] public int SecondaryIndex /* System.Int32 */;
    }

}

}

