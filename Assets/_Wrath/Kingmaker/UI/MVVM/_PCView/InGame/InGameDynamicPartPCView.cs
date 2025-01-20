using Kingmaker.UI._ConsoleUI.Overtips;
using Kingmaker.UI.MVVM._PCView.Lockpick;
using Kingmaker.UI.PointMarker;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._PCView.InGame {

public class InGameDynamicPartPCView {
    [SerializeField] public global::Kingmaker.UI._ConsoleUI.Overtips.OvertipsView m_OvertipsView /* Kingmaker.UI._ConsoleUI.Overtips.OvertipsView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.Lockpick.LockpickPCView m_LockpickView /* Kingmaker.UI.MVVM._PCView.Lockpick.LockpickPCView */;
    [SerializeField] public global::Kingmaker.UI.PointMarker.PointMarkerController m_MarkerController /* Kingmaker.UI.PointMarker.PointMarkerController */;
}

}

