using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.Visual.Animation.Misc {

public class KineticistIdleObjectSelector : MonoBehaviour {
    public List<KineticistIdleObjectSelector.ObjectPerElement> ObjectsElementList /* System.Collections.Generic.List<Kingmaker.Visual.Animation.Misc.ObjectPerElement> */;
    [SerializeField] public object m_KineticistClass /* Kingmaker.Blueprints.BlueprintCharacterClassReference */;

    public class ObjectPerElement {
        [SerializeField] public GameObject ElementFxObject /* UnityEngine.GameObject */;
        [SerializeField] public object m_ElementalProgression /* Kingmaker.Blueprints.BlueprintProgressionReference */;
    }

}

}

