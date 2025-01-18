using UnityEngine;

namespace Kingmaker.Controllers.Dialog {

public class DebugDialogPlayer : MonoBehaviour {
    [SerializeField] public object m_Dialog /* Kingmaker.Blueprints.BlueprintDialogReference */;
    [SerializeField] public object m_DefaultSpeaker /* Kingmaker.Blueprints.BlueprintUnitReference */;
    public GameObject Players /* UnityEngine.GameObject */;
    public GameObject Speakers /* UnityEngine.GameObject */;
    public GameObject Garage /* UnityEngine.GameObject */;
}

}

