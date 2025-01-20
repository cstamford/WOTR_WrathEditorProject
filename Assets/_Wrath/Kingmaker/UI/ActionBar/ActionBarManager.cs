using Kingmaker.UI.Common;
using Kingmaker.UI.Common.Animations;
using Kingmaker.UI.TurnBasedMode;
using System;
using UnityEngine;

namespace Kingmaker.UI.ActionBar {

public class ActionBarManager : global::UnityEngine.MonoBehaviour {
    public global::Kingmaker.UI.ActionBar.ActionBarSlots Slots /* Kingmaker.UI.ActionBar.ActionBarSlots */;
    public global::Kingmaker.UI.ActionBar.ActionBarGroup Group /* Kingmaker.UI.ActionBar.ActionBarGroup */;
    public global::Kingmaker.UI.ActionBar.ActionBarWeaponSetToggle WeaponSet /* Kingmaker.UI.ActionBar.ActionBarWeaponSetToggle */;
    public global::Kingmaker.UI.Common.UISection UISection /* Kingmaker.UI.Common.UISection */;
    public global::Kingmaker.UI.ActionBar.ActionBarAdditionalManager AdditionalManager /* Kingmaker.UI.ActionBar.ActionBarAdditionalManager */;
    public global::Kingmaker.UI.ActionBar.ActionBarAutoUsePanel AutoUsePanel /* Kingmaker.UI.ActionBar.ActionBarAutoUsePanel */;
    public global::Kingmaker.UI.ActionBar.KineticistBurnView KineticistPanel /* Kingmaker.UI.ActionBar.KineticistBurnView */;
    [SerializeField] public int m_GroupDeltaDeltaY /* System.Int32 */;
    [SerializeField] public int m_ShowPredictionPositionY /* System.Int32 */;
    [SerializeField] public int m_ShowAllPositionY /* System.Int32 */;
    [SerializeField] public int m_HidePositionY /* System.Int32 */;
    public global::Kingmaker.UI.ActionBar.ActionBarGroupSlot GroupSlot /* Kingmaker.UI.ActionBar.ActionBarGroupSlot */;
    public int HeaderSize /* System.Int32 */;
    public int LineSize /* System.Int32 */;
    public int SlotInLine /* System.Int32 */;
    [SerializeField] public global::Kingmaker.UI.TurnBasedMode.PredictionPanelPCView m_PredictionPanelView /* Kingmaker.UI.TurnBasedMode.PredictionPanelPCView */;
    [SerializeField] public global::Kingmaker.UI.Common.Animations.MoveAnimator m_UpperPart /* Kingmaker.UI.Common.Animations.MoveAnimator */;
    [SerializeField] public global::Kingmaker.UI.Common.Animations.FadeAnimator m_UpperPartFade /* Kingmaker.UI.Common.Animations.FadeAnimator */;
}

}

