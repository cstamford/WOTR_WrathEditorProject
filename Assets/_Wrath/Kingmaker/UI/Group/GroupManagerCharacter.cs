using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.Group {

public class GroupManagerCharacter : MonoBehaviour {
    [SerializeField] public Button m_RemoveButton /* UnityEngine.UI.Button */;
    [SerializeField] public CharacterBase m_Character /* Kingmaker.UI.Group.CharacterBase */;
    [SerializeField] public GameObject m_Lock /* UnityEngine.GameObject */;
    [SerializeField] public Image m_EmptyFrame /* UnityEngine.UI.Image */;
    [SerializeField] public GameObject m_CharacterFrame /* UnityEngine.GameObject */;
}

}

