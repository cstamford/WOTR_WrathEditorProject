using System;
using UnityEngine;

namespace Kingmaker.Plugins.DungeonArchitect.DLC3.Scripts {

public class DungeonData : global::UnityEngine.MonoBehaviour {
    public object Rooms /* Kingmaker.Plugins.DungeonArchitect.DLC3.Scripts.RoomData[] */;
    public global::Kingmaker.Plugins.DungeonArchitect.DLC3.Scripts.DungeonData.RoomData Exterior /* Kingmaker.Plugins.DungeonArchitect.DLC3.Scripts.RoomData */;

    public class RoomData {
        public int Number /* System.Int32 */;
        public int Distance /* System.Int32 */;
        public global::UnityEngine.Bounds Bounds /* UnityEngine.Bounds */;
        public bool IsSecret /* System.Boolean */;
    }

}

}

