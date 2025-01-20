using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.UI.MVVM._PCView.Lockpick {

public class LockpickBaseView {
    [SerializeField] public object m_DestroyButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public object m_CommonButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public object m_Lockpick05Button /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public object m_Lockpick10Button /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public object m_DestroyText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_CommonText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_Lockpick05Text /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_Lockpick10Text /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::System.Collections.Generic.List<global::UnityEngine.Vector2> m_PositionsForTwo /* System.Collections.Generic.List<UnityEngine.Vector2> */;
    [SerializeField] public global::System.Collections.Generic.List<global::UnityEngine.Vector2> m_PositionsForThree /* System.Collections.Generic.List<UnityEngine.Vector2> */;
    [SerializeField] public global::System.Collections.Generic.List<global::UnityEngine.Vector2> m_PositionsForFour /* System.Collections.Generic.List<UnityEngine.Vector2> */;
}

}

