using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.MVVM._PCView.Rest {

public class RestCraftRecipeItemPCView {
    [SerializeField] public object m_RecipeName /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.GameObject m_ForbiddenContainer /* UnityEngine.GameObject */;
    [SerializeField] public object m_ForbiddenState /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Rest.RestCraftProgressBar m_ProgressBar /* Kingmaker.UI.MVVM._PCView.Rest.RestCraftProgressBar */;
    [SerializeField] public global::UnityEngine.UI.Image m_ItemIcon /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.UI.Image m_DecorationBorder /* UnityEngine.UI.Image */;
    [SerializeField] public object m_LevelText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_DCText /* TMPro.TextMeshProUGUI */;
}

}

