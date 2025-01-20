using DG.Tweening;
using System;
using UnityEngine;

namespace Kingmaker.UI.ServiceWindow.Credits {

public class PersonElement : global::Kingmaker.UI.ServiceWindow.Credits.CreditElement {
    [SerializeField] public object NameLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object NameLabelHighlighted /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object RoleLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object RoleLabelHighlighted /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::DG.Tweening.DOTweenAnimation m_Ping /* DG.Tweening.DOTweenAnimation */;
}

}

