using UnityEngine;

namespace Kingmaker.View.Spawners {

public class SpawnerDifficultySettings : MonoBehaviour {
    public SpawnerDifficultySettings.Type Setting /* Kingmaker.View.Spawners.Type */;

    public enum Type {
        Any = 0,
        NormalAndHigher = 1,
        CoreAndHigher = 2,
    }

}

}

