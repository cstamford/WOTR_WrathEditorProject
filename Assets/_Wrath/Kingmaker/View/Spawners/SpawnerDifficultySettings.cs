using System;
using UnityEngine;

namespace Kingmaker.View.Spawners {

public class SpawnerDifficultySettings : global::UnityEngine.MonoBehaviour {
    public global::Kingmaker.View.Spawners.SpawnerDifficultySettings.Type Setting /* Kingmaker.View.Spawners.Type */;

    public enum Type {
        Any = 0,
        NormalAndHigher = 1,
        CoreAndHigher = 2,
    }

}

}

