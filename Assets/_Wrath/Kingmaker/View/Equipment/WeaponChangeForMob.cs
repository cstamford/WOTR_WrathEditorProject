using System;
using UnityEngine;

namespace Kingmaker.View.Equipment {

public class WeaponChangeForMob : MonoBehaviour {
    public bool InCombatOnly /* System.Boolean */;
    public GameObject ActivatedWeaponObject /* UnityEngine.GameObject */;
    public int ActivatedWeaponSet /* System.Int32 */;
    public GameObject FxObject /* UnityEngine.GameObject */;
    public object AppearFx /* Kingmaker.ResourceLinks.PrefabLink */;
    public object DisappearFx /* Kingmaker.ResourceLinks.PrefabLink */;
    public bool DelayFX /* System.Boolean */;
}

}

