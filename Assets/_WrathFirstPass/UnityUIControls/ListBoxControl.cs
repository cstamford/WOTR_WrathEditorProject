using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UnityUIControls {

public class ListBoxControl : global::UnityEngine.MonoBehaviour {
    [SerializeField] public global::System.Collections.Generic.List<global::UnityUIControls.ListBoxControl.StartingListItem> _startArray /* System.Collections.Generic.List<UnityUIControls.StartingListItem> */;
    [SerializeField] public string _strTitle /* System.String */;
    [SerializeField] public bool _blnBestFit /* System.Boolean */;
    [SerializeField] public bool _blnAllowDblClick /* System.Boolean */;
    [SerializeField] public bool _blnPartOfDDL /* System.Boolean */;
    public global::UnityEngine.GameObject ScrollBarObject /* UnityEngine.GameObject */;
    public global::UnityEngine.GameObject ScrollRectObject /* UnityEngine.GameObject */;
    public global::UnityEngine.GameObject ScrollContainerObject /* UnityEngine.GameObject */;
    public global::UnityEngine.UI.Text ListBoxTitle /* UnityEngine.UI.Text */;
    public global::UnityEngine.GameObject ListBoxLineItemPrefabObject /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.Color ItemNormalColor /* UnityEngine.Color */;
    [SerializeField] public global::UnityEngine.Color ItemHighlightColor /* UnityEngine.Color */;
    [SerializeField] public global::UnityEngine.Color ItemSelectedColor /* UnityEngine.Color */;
    [SerializeField] public global::UnityEngine.Color ItemDisabledColor /* UnityEngine.Color */;
    [SerializeField] public bool CanMultiSelect /* System.Boolean */;
    [SerializeField] public float Height /* System.Single */;
    [SerializeField] public float Spacing /* System.Single */;
    [SerializeField] public global::System.Char SeparatorChar /* System.Char */;

    public class StartingListItem {
        public string Value /* System.String */;
        public string Text /* System.String */;
        public string SubText /* System.String */;
        public global::UnityEngine.Sprite Icon /* UnityEngine.Sprite */;
        public int Index /* System.Int32 */;
    }

}

}

