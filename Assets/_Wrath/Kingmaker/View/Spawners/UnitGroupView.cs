using Kingmaker.View;
using System;
using UnityEngine;

namespace Kingmaker.View.Spawners {

public class UnitGroupView {
    public global::UnityEngine.Color GizmosColor /* UnityEngine.Color */;
    public global::Kingmaker.View.Spawners.UnitGroupView.MusicCombatState CombatMusic /* Kingmaker.View.Spawners.MusicCombatState */;
    public bool DisableOnSimplified /* System.Boolean */;
    public bool IgnoreInEncoutnerStatistic /* System.Boolean */;

    public enum MusicCombatState {
        Ignore = -1,
        Normal = 0,
        Boss = 1,
    }

}

}

