using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.UI.GlobalMap {

public class GlobalMapBarkManager : MonoBehaviour {
    [SerializeField] public List<GlobalMapBarkManager.CharacterBarkPair> m_CharactersBarkPairs /* System.Collections.Generic.List<Kingmaker.UI.GlobalMap.CharacterBarkPair> */;

    public class CharacterBarkPair {
        public object Balloon /* Kingmaker.UI.GlobalMap.GlobalMapGroupCharacterBalloon */;
        public object Character /* Kingmaker.UI.Group.GroupCharacter */;
    }

}

}

