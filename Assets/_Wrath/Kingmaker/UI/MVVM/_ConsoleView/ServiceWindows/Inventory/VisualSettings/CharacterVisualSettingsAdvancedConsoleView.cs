using Kingmaker.UI.Common;
using Kingmaker.UI.MVVM._VM.Utility.CanvasSorting;
using Kingmaker.UI.ServiceWindow;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._ConsoleView.ServiceWindows.Inventory.VisualSettings {

public class CharacterVisualSettingsAdvancedConsoleView {
    [SerializeField] public global::Kingmaker.UI.ServiceWindow.DollRoomCharacterController m_DollRoom /* Kingmaker.UI.ServiceWindow.DollRoomCharacterController */;
    [SerializeField] public float m_RotateFactor /* System.Single */;
    [SerializeField] public global::Kingmaker.UI.Common.ScrollRectExtended m_ScrollRect /* Kingmaker.UI.Common.ScrollRectExtended */;
    [SerializeField] public object m_CloseHint /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHint */;
    [SerializeField] public object m_HintsWidget /* Owlcat.Runtime.UI.ConsoleTools.HintTool.ConsoleHintsWidget */;
    [SerializeField] public global::Kingmaker.UI.MVVM._VM.Utility.CanvasSorting.CanvasSortingComponent m_SortingComponent /* Kingmaker.UI.MVVM._VM.Utility.CanvasSorting.CanvasSortingComponent */;
}

}

