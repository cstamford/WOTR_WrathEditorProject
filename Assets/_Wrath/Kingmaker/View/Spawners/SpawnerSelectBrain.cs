using System;
using UnityEngine;

namespace Kingmaker.View.Spawners {

public class SpawnerSelectBrain {
    [SerializeField] public global::Kingmaker.View.Spawners.SpawnerSelectBrain.BrainSelector Brain /* Kingmaker.View.Spawners.BrainSelector */;

    public class BrainSelector {
        public object Current /* Kingmaker.Blueprints.BlueprintBrainReference */;
    }

}

}

