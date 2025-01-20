using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.Group {

public class GroupManagerCharacter : global::UnityEngine.MonoBehaviour {
    [SerializeField] public global::UnityEngine.UI.Button m_RemoveButton /* UnityEngine.UI.Button */;
    [SerializeField] public global::Kingmaker.UI.Group.CharacterBase m_Character /* Kingmaker.UI.Group.CharacterBase */;
    [SerializeField] public global::UnityEngine.GameObject m_Lock /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.UI.Image m_EmptyFrame /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.GameObject m_CharacterFrame /* UnityEngine.GameObject */;
}

}

