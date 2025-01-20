using System;
using UnityEngine;

namespace Kingmaker.Blueprints.Root.Strings {

public class FeatureTagString : global::UnityEngine.ScriptableObject {
    public object Entries /* Kingmaker.Blueprints.Root.Strings.Entry[] */;

    public class Entry {
        public object Tag /* Kingmaker.Blueprints.Classes.Selection.FeatureTag */;
        public object Text /* Kingmaker.Localization.LocalizedString */;
    }

}

}

