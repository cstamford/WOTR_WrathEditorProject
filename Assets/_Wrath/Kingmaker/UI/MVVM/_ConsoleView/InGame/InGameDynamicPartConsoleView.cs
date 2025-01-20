using Kingmaker.UI._ConsoleUI.Overtips;
using Kingmaker.UI.MVVM._ConsoleView.Lockpick;
using Kingmaker.UI.PointMarker;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._ConsoleView.InGame {

public class InGameDynamicPartConsoleView {
    [SerializeField] public global::Kingmaker.UI._ConsoleUI.Overtips.OvertipsView m_OvertipsView /* Kingmaker.UI._ConsoleUI.Overtips.OvertipsView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Lockpick.LockpickConsoleView m_LockpickConsoleView /* Kingmaker.UI.MVVM._ConsoleView.Lockpick.LockpickConsoleView */;
    [SerializeField] public global::Kingmaker.UI.PointMarker.PointMarkerController m_PointMarkerController /* Kingmaker.UI.PointMarker.PointMarkerController */;
}

}

