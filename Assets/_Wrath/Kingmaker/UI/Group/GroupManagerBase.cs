using UnityEngine;

namespace Kingmaker.UI.Group {

public class GroupManagerBase : MonoBehaviour {
    [SerializeField] public Transform ActiveCompanions /* UnityEngine.Transform */;
    [SerializeField] public Transform RemoteCompanions /* UnityEngine.Transform */;
    [SerializeField] public GroupManagerCharacter m_Character /* Kingmaker.UI.Group.GroupManagerCharacter */;
}

}

