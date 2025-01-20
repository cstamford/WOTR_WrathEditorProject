using System;
using UnityEngine;

namespace Kingmaker.UI.Kingdom {

public class KingdomUIEventWindowFooter : global::UnityEngine.MonoBehaviour {
    [SerializeField] public object m_StartEvent /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public object m_StartEventLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_Ignore /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public object m_Unignore /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public object m_ThroneRoom /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public object m_Cancel /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public object m_Drop /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public object m_DropLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_GoThroneRoomLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_Close /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public global::Kingmaker.UI.Kingdom.KingdomUIEventWindowFooterRequirement m_Requirement /* Kingmaker.UI.Kingdom.KingdomUIEventWindowFooterRequirement */;
    [SerializeField] public global::Kingmaker.UI.Kingdom.KingdomUIEventWindowFooterSolutionGroup m_Solutions /* Kingmaker.UI.Kingdom.KingdomUIEventWindowFooterSolutionGroup */;
    [SerializeField] public object m_TaskWasIgnore /* TMPro.TextMeshProUGUI */;
}

}

