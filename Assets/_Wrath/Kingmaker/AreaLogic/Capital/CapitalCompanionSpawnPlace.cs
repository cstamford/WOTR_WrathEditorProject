using Kingmaker.Localization;
using UnityEngine;

namespace Kingmaker.AreaLogic.Capital {

public class CapitalCompanionSpawnPlace : MonoBehaviour {
    [SerializeField] public object m_CompanionBlueprint /* Kingmaker.Blueprints.BlueprintUnitReference */;
    [SerializeField] public object m_OverrideDialog /* Kingmaker.Blueprints.BlueprintDialogReference */;
    public SharedStringAsset OverrideBark /* Kingmaker.Localization.SharedStringAsset */;
}

}

