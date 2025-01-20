using Kingmaker.UI.Common;
using Kingmaker.UI.MVVM._PCView.CharGen.Phases.Common;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.MVVM._CommonView.CharGen.Phases.Common {

public class TextureSelectorCommonView {
    [SerializeField] public object m_Label /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.Common.WidgetListMVVM m_WidgetList /* Kingmaker.UI.Common.WidgetListMVVM */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.CharGen.Phases.Common.TextureSelectorItemPCView m_ItemPrefab /* Kingmaker.UI.MVVM._PCView.CharGen.Phases.Common.TextureSelectorItemPCView */;
    [SerializeField] public global::Kingmaker.UI.Common.Paginator m_Paginator /* Kingmaker.UI.Common.Paginator */;
    [SerializeField] public global::UnityEngine.UI.LayoutElement m_LayoutElement /* UnityEngine.UI.LayoutElement */;
    [SerializeField] public int m_RowNumber /* System.Int32 */;
    [SerializeField] public float m_RowHeight /* System.Single */;
}

}

