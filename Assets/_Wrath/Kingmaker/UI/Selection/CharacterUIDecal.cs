using Kingmaker.Visual.Decals;
using System;
using UnityEngine;

namespace Kingmaker.UI.Selection {

public class CharacterUIDecal {
    [SerializeField] public global::UnityEngine.GameObject m_Container /* UnityEngine.GameObject */;
    public global::UnityEngine.GameObject Select /* UnityEngine.GameObject */;
    public global::UnityEngine.GameObject ConsoleCurrentUnitSelect /* UnityEngine.GameObject */;
    public global::UnityEngine.Color SelectionColor /* UnityEngine.Color */;
    [SerializeField] public global::Kingmaker.Visual.Decals.GUIDecal m_SpellSelectionRange /* Kingmaker.Visual.Decals.GUIDecal */;
    [SerializeField] public global::Kingmaker.Visual.Decals.GUIDecal m_SpellSelectionRangeBack /* Kingmaker.Visual.Decals.GUIDecal */;
    [SerializeField] public global::Kingmaker.Visual.Decals.GUIDecal m_CurrentSpellRange /* Kingmaker.Visual.Decals.GUIDecal */;
    [SerializeField] public global::Kingmaker.Visual.Decals.GUIDecal m_CurrentSpellRangeBack /* Kingmaker.Visual.Decals.GUIDecal */;
}

}

