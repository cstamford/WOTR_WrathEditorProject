using Kingmaker.Assets.UI.Common;
using Kingmaker.UI.Common.Animations;
using Kingmaker.UI.ServiceWindow;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.Loot {

public class LootWindowController {
    [SerializeField] public global::Kingmaker.UI.Loot.LootCollector m_Collector /* Kingmaker.UI.Loot.LootCollector */;
    [SerializeField] public global::Kingmaker.UI.Loot.StashInLoot m_Stash /* Kingmaker.UI.Loot.StashInLoot */;
    [SerializeField] public global::UnityEngine.GameObject m_StashContainer /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.UI.Image m_StashBackGround /* UnityEngine.UI.Image */;
    [SerializeField] public global::Kingmaker.Assets.UI.Common.DraggbleWindow m_DraggbleWindow /* Kingmaker.Assets.UI.Common.DraggbleWindow */;
    public object PlayerMoneyNow /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.ServiceWindow.Inventory.EncumbranceContainer m_StashEncumbrance /* Kingmaker.UI.ServiceWindow.EncumbranceContainer */;
    [SerializeField] public global::Kingmaker.UI.Common.Animations.WindowAnimator m_CollectorAnimator /* Kingmaker.UI.Common.Animations.WindowAnimator */;
    [SerializeField] public global::UnityEngine.Transform m_WindowContainer /* UnityEngine.Transform */;
    public object WindowMode /* Kingmaker.UI.Loot.LootWindowMode */;
    [SerializeField] public float m_ButtonShift /* System.Single */;
    [SerializeField] public global::UnityEngine.RectTransform m_OwnRectTransform /* UnityEngine.RectTransform */;
    [SerializeField] public global::UnityEngine.RectTransform m_ParentRectTransform /* UnityEngine.RectTransform */;
    public bool PositionDirty /* System.Boolean */;
    [SerializeField] public global::UnityEngine.UI.Button m_LeaveZoneButton /* UnityEngine.UI.Button */;
    [SerializeField] public object m_ButtonLeaveZoneText /* TMPro.TextMeshProUGUI */;
    public bool m_LeavePressed /* System.Boolean */;
}

}

