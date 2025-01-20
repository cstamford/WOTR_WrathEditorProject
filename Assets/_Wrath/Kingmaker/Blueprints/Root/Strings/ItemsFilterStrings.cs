using System;
using UnityEngine;

namespace Kingmaker.Blueprints.Root.Strings {

public class ItemsFilterStrings {
    public object SorterTypeEntries /* Kingmaker.Blueprints.Root.Strings.SorterTypeEntry[] */;
    public object FilterTypentries /* Kingmaker.Blueprints.Root.Strings.FilterTypeEntry[] */;

    public class SorterTypeEntry {
        public object SorterType /* Kingmaker.UI.Common.SorterType */;
        public object Text /* Kingmaker.Localization.LocalizedString */;
    }

    public class FilterTypeEntry {
        public object FilterType /* Kingmaker.UI.Common.FilterType */;
        public object Text /* Kingmaker.Localization.LocalizedString */;
    }

}

}

