using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.Localization {

public class LocalizedUIText : global::UnityEngine.MonoBehaviour {
    public global::Kingmaker.Localization.SharedStringAsset Text /* Kingmaker.Localization.SharedStringAsset */;
    public bool IsSaber /* System.Boolean */;
    [SerializeField] public global::System.Collections.Generic.List<global::Kingmaker.Localization.LocalizedUIText.DlcText> DlcTexts /* System.Collections.Generic.List<Kingmaker.Localization.DlcText> */;

    public class DlcText {
        [SerializeField] public object m_Dlc /* Kingmaker.Blueprints.BlueprintDlcReference */;
        public global::Kingmaker.Localization.SharedStringAsset Text /* Kingmaker.Localization.SharedStringAsset */;
    }

}

}

