using System;
using UnityEngine;
using UnityEngine.UI;

namespace UnityUIControls {

public class DropDownListControl : global::UnityUIControls.ListBoxControl {
    [SerializeField] public string _strStartingValue /* System.String */;
    [SerializeField] public string _strPlaceholder /* System.String */;
    [SerializeField] public float _fHeight /* System.Single */;
    public global::UnityEngine.GameObject ParentContainer /* UnityEngine.GameObject */;
    public global::UnityEngine.UI.Text SelectedTextObject /* UnityEngine.UI.Text */;
    public global::UnityEngine.GameObject DropDownButton /* UnityEngine.GameObject */;
    public global::UnityUIControls.ListBoxControl DdlListBox /* UnityUIControls.ListBoxControl */;
}

}

