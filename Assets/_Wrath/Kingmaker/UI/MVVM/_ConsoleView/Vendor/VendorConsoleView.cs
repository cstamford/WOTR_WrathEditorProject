using Kingmaker.UI.Common.Animations;
using Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.Inventory;
using Kingmaker.UI.MVVM._ConsoleView.Slots;
using Kingmaker.UI.MVVM._PCView.InfoWindow;
using Kingmaker.UI.MVVM._PCView.Slots;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._ConsoleView.Vendor {

public class VendorConsoleView {
    [SerializeField] public object m_VendorName /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Slots.ItemSlotsGroupView m_VendorGroup /* Kingmaker.UI.MVVM._PCView.Slots.ItemSlotsGroupView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Slots.ItemsFilterConsoleView m_VendorItemsFilter /* Kingmaker.UI.MVVM._ConsoleView.Slots.ItemsFilterConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Vendor.VendorSlotConsoleView m_VendorSlotPrefab /* Kingmaker.UI.MVVM._ConsoleView.Vendor.VendorSlotConsoleView */;
    [SerializeField] public global::UnityEngine.GameObject m_Placeholder /* UnityEngine.GameObject */;
    [SerializeField] public object m_BuyZoneHeader /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.Inventory.InventoryDollConsoleView m_DollConsoleView /* Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.Inventory.InventoryDollConsoleView */;
    [SerializeField] public float m_RotateFactor /* System.Single */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.Inventory.InventoryStashConsoleView m_PlayerStashView /* Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.Inventory.InventoryStashConsoleView */;
    [SerializeField] public object m_CharacterName /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_SellZoneHeader /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Vendor.VendorOptionsConsoleView m_OptionsView /* Kingmaker.UI.MVVM._ConsoleView.Vendor.VendorOptionsConsoleView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Slots.ItemSlotsGroupView m_PlayerExchangeGroup /* Kingmaker.UI.MVVM._PCView.Slots.ItemSlotsGroupView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Slots.ItemSlotsGroupView m_VendorExchangeGroup /* Kingmaker.UI.MVVM._PCView.Slots.ItemSlotsGroupView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Vendor.VendorGenericSlotConsoleView m_VendorGenericSlotView /* Kingmaker.UI.MVVM._ConsoleView.Vendor.VendorGenericSlotConsoleView */;
    [SerializeField] public object m_VendorWeightText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_PlayerWeightText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_VendorPriceText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_PlayerPriceText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_DealLabel /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_DealPrice /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_DealWeight /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_DealPlayerMoneyText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_DealPlayerWeightText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.Common.Animations.MoveAnimator m_MoveAnimator /* Kingmaker.UI.Common.Animations.MoveAnimator */;
    [SerializeField] public object m_DealHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_ConfirmHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_CloseHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_MassSaleHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_InformationHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_InformationExpandHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_BackToStashHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_CopyDealHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_ShowCharInventoryHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.InfoWindow.InfoSectionView m_RightInfoSectionView /* Kingmaker.UI.MVVM._PCView.InfoWindow.InfoSectionView */;
    [SerializeField] public global::UnityEngine.RectTransform m_ItemInformationBlock /* UnityEngine.RectTransform */;
    [SerializeField] public global::UnityEngine.RectTransform m_PlayerStashInfoPlace /* UnityEngine.RectTransform */;
    [SerializeField] public global::UnityEngine.RectTransform m_VendorStashInfoPlace /* UnityEngine.RectTransform */;
    [SerializeField] public global::UnityEngine.RectTransform m_SellInfoPlace /* UnityEngine.RectTransform */;
    [SerializeField] public global::UnityEngine.RectTransform m_BuyInfoPlace /* UnityEngine.RectTransform */;
    [SerializeField] public global::UnityEngine.GameObject m_PointToBuyArrow /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.GameObject m_PointToSellArrow /* UnityEngine.GameObject */;
    [SerializeField] public object m_PointToBuyArrowText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_PointToSellArrowText /* TMPro.TextMeshProUGUI */;
}

}

