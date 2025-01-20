using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.UI.MVVM._PCView.Rest {

public class RestCraftRecipePCView {
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Rest.RestRecipeItemsSelectorPCView m_RecipeItemSelector /* Kingmaker.UI.MVVM._PCView.Rest.RestRecipeItemsSelectorPCView */;
    [SerializeField] public global::System.Collections.Generic.List<global::Kingmaker.UI.MVVM._PCView.Rest.RestRecipeIngredientItemPCView> m_IngredientItemViews /* System.Collections.Generic.List<Kingmaker.UI.MVVM._PCView.Rest.RestRecipeIngredientItemPCView> */;
    [SerializeField] public object m_CloseButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public object m_BackButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public object m_BackButtonText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_ApplyButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatButton */;
    [SerializeField] public object m_ApplyButtonText /* TMPro.TextMeshProUGUI */;
}

}

