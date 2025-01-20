using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.UI.ServiceWindow {

public class DollWeaponSets : global::Kingmaker.UI.ServiceWindow.WeaponSetsBase {
    public global::System.Collections.Generic.List<global::Kingmaker.UI.ServiceWindow.DollWeaponSets.WeaponSetPair> Positions /* System.Collections.Generic.List<Kingmaker.UI.ServiceWindow.WeaponSetPair> */;
    public global::Kingmaker.UI.ServiceWindow.DollWeaponSet WeaponSet /* Kingmaker.UI.ServiceWindow.DollWeaponSet */;

    public class WeaponSetPair {
        public global::UnityEngine.Transform Position /* UnityEngine.Transform */;
        public int Index /* System.Int32 */;
    }

}

}

