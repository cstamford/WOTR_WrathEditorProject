using Kingmaker.UI.MVVM._PCView.Dialog.BookEvent;
using Kingmaker.UI.MVVM._PCView.Dialog.Dialog;
using Kingmaker.UI.MVVM._PCView.Dialog.Interchapter;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._PCView.Dialog {

public class DialogContextPCView {
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Dialog.Dialog.DialogPCView m_DialogPCView /* Kingmaker.UI.MVVM._PCView.Dialog.Dialog.DialogPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Dialog.BookEvent.BookEventPCView m_BookEventPCView /* Kingmaker.UI.MVVM._PCView.Dialog.BookEvent.BookEventPCView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Dialog.Interchapter.InterchapterPCView m_InterchapterPCView /* Kingmaker.UI.MVVM._PCView.Dialog.Interchapter.InterchapterPCView */;
}

}

