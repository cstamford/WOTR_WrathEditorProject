using Kingmaker.UI.Common;
using Kingmaker.UI.Common.Animations;
using System;
using UnityEngine;

namespace Kingmaker.UI.ActionBar {

public class ActionBarManager : MonoBehaviour {
    public ActionBarSlots Slots /* Kingmaker.UI.ActionBar.ActionBarSlots */;
    public ActionBarGroup Group /* Kingmaker.UI.ActionBar.ActionBarGroup */;
    public ActionBarWeaponSetToggle WeaponSet /* Kingmaker.UI.ActionBar.ActionBarWeaponSetToggle */;
    public UISection UISection /* Kingmaker.UI.Common.UISection */;
    public ActionBarAdditionalManager AdditionalManager /* Kingmaker.UI.ActionBar.ActionBarAdditionalManager */;
    public ActionBarAutoUsePanel AutoUsePanel /* Kingmaker.UI.ActionBar.ActionBarAutoUsePanel */;
    public KineticistBurnView KineticistPanel /* Kingmaker.UI.ActionBar.KineticistBurnView */;
    [SerializeField] public int m_GroupDeltaDeltaY /* System.Int32 */;
    [SerializeField] public int m_ShowPredictionPositionY /* System.Int32 */;
    [SerializeField] public int m_ShowAllPositionY /* System.Int32 */;
    [SerializeField] public int m_HidePositionY /* System.Int32 */;
    public object GroupSlot /* Kingmaker.UI.ActionBar.ActionBarGroupSlot */;
    public int HeaderSize /* System.Int32 */;
    public int LineSize /* System.Int32 */;
    public int SlotInLine /* System.Int32 */;
    [SerializeField] public object m_PredictionPanelView /* Kingmaker.UI.TurnBasedMode.PredictionPanelPCView */;
    [SerializeField] public MoveAnimator m_UpperPart /* Kingmaker.UI.Common.Animations.MoveAnimator */;
    [SerializeField] public FadeAnimator m_UpperPartFade /* Kingmaker.UI.Common.Animations.FadeAnimator */;
}

}

