using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.UI.ActionBar {

public class ActionBarSubGroupLevels : global::UnityEngine.MonoBehaviour {
    [SerializeField] public global::System.Collections.Generic.List<global::Kingmaker.UI.ActionBar.ActionBarSubGroupLevels.LevelButtonPair> m_LevelButtonPairs /* System.Collections.Generic.List<Kingmaker.UI.ActionBar.LevelButtonPair> */;
    public int Index /* System.Int32 */;

    public class LevelButtonPair {
        public int Index /* System.Int32 */;
        public global::Kingmaker.UI.ActionBar.ActionBarSubGroupLevelElement Level /* Kingmaker.UI.ActionBar.ActionBarSubGroupLevelElement */;
    }

}

}

