using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._PCView.ServiceWindows.Journal {

public class JournalNavigationGroupElementBaseView {
    [SerializeField] public object m_MultiButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
    [SerializeField] public object m_Label /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.GameObject m_FailedMark /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.GameObject m_CompletedMark /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.GameObject m_AttentionMark /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.GameObject m_LastChapterMark /* UnityEngine.GameObject */;
}

}

