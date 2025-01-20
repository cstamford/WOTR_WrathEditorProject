using Kingmaker.UI.MVVM._PCView.Dungeon;
using Kingmaker.UI.MVVM._VM.Utility.CanvasSorting;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._ConsoleView.Dungeon {

public class DungeonGameOverConsoleView {
    [SerializeField] public object m_StartNewGameButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
    [SerializeField] public object m_LoadLatestSaveButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
    [SerializeField] public object m_MainMenuButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
    [SerializeField] public global::Kingmaker.UI.MVVM._VM.Utility.CanvasSorting.CanvasSortingComponent m_SortingComponent /* Kingmaker.UI.MVVM._VM.Utility.CanvasSorting.CanvasSortingComponent */;
}

}

