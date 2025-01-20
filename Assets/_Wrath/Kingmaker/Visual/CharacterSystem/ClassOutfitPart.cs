using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.Visual.CharacterSystem {

public class ClassOutfitPart : global::UnityEngine.ScriptableObject {
    public global::System.Collections.Generic.List<global::Kingmaker.Visual.CharacterSystem.ClassOutfitPart.OverrideClassOutfitPart> male /* System.Collections.Generic.List<Kingmaker.Visual.CharacterSystem.OverrideClassOutfitPart> */;
    public global::System.Collections.Generic.List<global::Kingmaker.Visual.CharacterSystem.ClassOutfitPart.OverrideClassOutfitPart> female /* System.Collections.Generic.List<Kingmaker.Visual.CharacterSystem.OverrideClassOutfitPart> */;

    public class OverrideClassOutfitPart {
        public global::Kingmaker.Visual.CharacterSystem.CharacterStudio.Race m_Race /* Kingmaker.Visual.CharacterSystem.Race */;
        public global::Kingmaker.Visual.CharacterSystem.EquipmentEntity.OutfitPart m_outfitPart /* Kingmaker.Visual.CharacterSystem.OutfitPart */;
    }

}

}

