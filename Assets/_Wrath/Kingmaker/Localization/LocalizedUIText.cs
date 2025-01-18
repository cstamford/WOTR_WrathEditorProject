using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.Localization {

public class LocalizedUIText : MonoBehaviour {
    public SharedStringAsset Text /* Kingmaker.Localization.SharedStringAsset */;
    public bool IsSaber /* System.Boolean */;
    [SerializeField] public List<LocalizedUIText.DlcText> DlcTexts /* System.Collections.Generic.List<Kingmaker.Localization.DlcText> */;

    public class DlcText {
        [SerializeField] public object m_Dlc /* Kingmaker.Blueprints.BlueprintDlcReference */;
        public SharedStringAsset Text /* Kingmaker.Localization.SharedStringAsset */;
    }

}

}

