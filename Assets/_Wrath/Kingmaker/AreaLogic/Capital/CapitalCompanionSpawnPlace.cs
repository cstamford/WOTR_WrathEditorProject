using Kingmaker.Localization;
using System;
using UnityEngine;

namespace Kingmaker.AreaLogic.Capital {

public class CapitalCompanionSpawnPlace : global::UnityEngine.MonoBehaviour {
    [SerializeField] public object m_CompanionBlueprint /* Kingmaker.Blueprints.BlueprintUnitReference */;
    [SerializeField] public object m_OverrideDialog /* Kingmaker.Blueprints.BlueprintDialogReference */;
    public global::Kingmaker.Localization.SharedStringAsset OverrideBark /* Kingmaker.Localization.SharedStringAsset */;
}

}

