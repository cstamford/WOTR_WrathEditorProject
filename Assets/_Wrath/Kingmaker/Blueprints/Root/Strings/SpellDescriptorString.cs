using System;
using UnityEngine;

namespace Kingmaker.Blueprints.Root.Strings {

public class SpellDescriptorString : ScriptableObject {
    public object Entries /* Kingmaker.Blueprints.Root.Strings.Entry[] */;

    public class Entry {
        [SerializeField] public object Descriptor /* Kingmaker.Blueprints.Classes.Spells.SpellDescriptorWrapper */;
        public object Text /* Kingmaker.Localization.LocalizedString */;
    }

}

}

