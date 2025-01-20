using System;
using UnityEngine;

namespace Kingmaker.Plugins.DungeonArchitect.DLC3.Scripts {

public class SelectorRuleConditional {
    public bool Not /* System.Boolean */;
    public global::Kingmaker.Plugins.DungeonArchitect.DLC3.Scripts.SelectorRuleConditional.ConditionType Type /* Kingmaker.Plugins.DungeonArchitect.DLC3.Scripts.ConditionType */;
    public object Rules /* DungeonArchitect.SelectorRule[] */;

    public enum ConditionType {
        AND = 0,
        OR = 1,
        ONE = 2,
    }

}

}

