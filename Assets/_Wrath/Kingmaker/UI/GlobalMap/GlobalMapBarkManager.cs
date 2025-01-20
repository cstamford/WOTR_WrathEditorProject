using Kingmaker.UI.Group;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.UI.GlobalMap {

public class GlobalMapBarkManager : global::UnityEngine.MonoBehaviour {
    [SerializeField] public global::System.Collections.Generic.List<global::Kingmaker.UI.GlobalMap.GlobalMapBarkManager.CharacterBarkPair> m_CharactersBarkPairs /* System.Collections.Generic.List<Kingmaker.UI.GlobalMap.CharacterBarkPair> */;

    public class CharacterBarkPair {
        public global::Kingmaker.UI.GlobalMap.GlobalMapGroupCharacterBalloon Balloon /* Kingmaker.UI.GlobalMap.GlobalMapGroupCharacterBalloon */;
        public global::Kingmaker.UI.Group.GroupCharacter Character /* Kingmaker.UI.Group.GroupCharacter */;
    }

}

}

