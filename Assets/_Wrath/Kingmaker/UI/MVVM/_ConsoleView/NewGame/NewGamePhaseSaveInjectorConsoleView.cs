using Kingmaker.UI.LevelUp;
using Kingmaker.UI.MVVM._ConsoleView.SaveLoad;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._ConsoleView.NewGame {

public class NewGamePhaseSaveInjectorConsoleView {
    [SerializeField] public object m_Title /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.LevelUp.CharBPortraitChanger m_PortraitChanger /* Kingmaker.UI.LevelUp.CharBPortraitChanger */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.SaveLoad.SaveSlotCollectionVirtualConsoleView m_SaveCollectionView /* Kingmaker.UI.MVVM._ConsoleView.SaveLoad.SaveSlotCollectionVirtualConsoleView */;
    [SerializeField] public object m_NewCharacterButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
    [SerializeField] public object m_NewCharacterButtonTitle /* TMPro.TextMeshProUGUI */;
}

}

