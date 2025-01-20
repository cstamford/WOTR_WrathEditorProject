using Kingmaker.UI.Common;
using System;
using UnityEngine;

namespace Kingmaker.UI.ServiceWindow.CharacterScreen {

public class CharSSkills : global::Kingmaker.UI.Common.UISection {
    public object MainLabel /* TMPro.TextMeshProUGUI */;
    public global::UnityEngine.Transform SkillsBox /* UnityEngine.Transform */;
    public object SkillTypes /* System.Collections.Generic.List */;
    [SerializeField] public global::UnityEngine.Sprite m_SkillBorderBackground /* UnityEngine.Sprite */;
    [SerializeField] public global::UnityEngine.Sprite m_SkillFilledBackground /* UnityEngine.Sprite */;
    [SerializeField] public bool m_ShowPermanentValue /* System.Boolean */;
}

}

