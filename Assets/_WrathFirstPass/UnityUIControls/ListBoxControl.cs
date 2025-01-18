using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UnityUIControls {

public class ListBoxControl : MonoBehaviour {
    [SerializeField] public List<ListBoxControl.StartingListItem> _startArray /* System.Collections.Generic.List<UnityUIControls.StartingListItem> */;
    [SerializeField] public string _strTitle /* System.String */;
    [SerializeField] public bool _blnBestFit /* System.Boolean */;
    [SerializeField] public bool _blnAllowDblClick /* System.Boolean */;
    [SerializeField] public bool _blnPartOfDDL /* System.Boolean */;
    public GameObject ScrollBarObject /* UnityEngine.GameObject */;
    public GameObject ScrollRectObject /* UnityEngine.GameObject */;
    public GameObject ScrollContainerObject /* UnityEngine.GameObject */;
    public Text ListBoxTitle /* UnityEngine.UI.Text */;
    public GameObject ListBoxLineItemPrefabObject /* UnityEngine.GameObject */;
    [SerializeField] public Color ItemNormalColor /* UnityEngine.Color */;
    [SerializeField] public Color ItemHighlightColor /* UnityEngine.Color */;
    [SerializeField] public Color ItemSelectedColor /* UnityEngine.Color */;
    [SerializeField] public Color ItemDisabledColor /* UnityEngine.Color */;
    [SerializeField] public bool CanMultiSelect /* System.Boolean */;
    [SerializeField] public float Height /* System.Single */;
    [SerializeField] public float Spacing /* System.Single */;
    [SerializeField] public Char SeparatorChar /* System.Char */;

    public class StartingListItem {
        public string Value /* System.String */;
        public string Text /* System.String */;
        public string SubText /* System.String */;
        public Sprite Icon /* UnityEngine.Sprite */;
        public int Index /* System.Int32 */;
    }

}

}

