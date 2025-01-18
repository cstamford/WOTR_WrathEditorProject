using UnityEngine;

namespace Kingmaker.Blueprints.Root {

public class PregenCharacterNames : ScriptableObject {
    [SerializeField] public object m_CharacterNames /* System.Collections.Generic.List */;
    [SerializeField] public object m_PetNames /* Kingmaker.Localization.LocalizedString */;
}

}

