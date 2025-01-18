using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.UI.ActionBar {

public class ActionBarSubGroupLevels : MonoBehaviour {
    [SerializeField] public List<ActionBarSubGroupLevels.LevelButtonPair> m_LevelButtonPairs /* System.Collections.Generic.List<Kingmaker.UI.ActionBar.LevelButtonPair> */;
    public int Index /* System.Int32 */;

    public class LevelButtonPair {
        public int Index /* System.Int32 */;
        public object Level /* Kingmaker.UI.ActionBar.ActionBarSubGroupLevelElement */;
    }

}

}

