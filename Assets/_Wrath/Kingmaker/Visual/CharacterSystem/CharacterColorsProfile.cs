using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.Visual.CharacterSystem {

public class CharacterColorsProfile : ScriptableObject {
    public List<Texture2D> Ramps /* System.Collections.Generic.List<UnityEngine.Texture2D> */;
    [SerializeField] public object RampDlcLocks /* System.Collections.Generic.List */;
    public List<Texture2D> SpecialRamps /* System.Collections.Generic.List<UnityEngine.Texture2D> */;
}

}

