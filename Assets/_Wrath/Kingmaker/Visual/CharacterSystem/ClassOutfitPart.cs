using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.Visual.CharacterSystem {

public class ClassOutfitPart : ScriptableObject {
    public List<ClassOutfitPart.OverrideClassOutfitPart> male /* System.Collections.Generic.List<Kingmaker.Visual.CharacterSystem.OverrideClassOutfitPart> */;
    public List<ClassOutfitPart.OverrideClassOutfitPart> female /* System.Collections.Generic.List<Kingmaker.Visual.CharacterSystem.OverrideClassOutfitPart> */;

    public class OverrideClassOutfitPart {
        public CharacterStudio.Race m_Race /* Kingmaker.Visual.CharacterSystem.Race */;
        public EquipmentEntity.OutfitPart m_outfitPart /* Kingmaker.Visual.CharacterSystem.OutfitPart */;
    }

}

}

