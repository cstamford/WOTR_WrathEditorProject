using Kingmaker.UI.LevelUp;
using Kingmaker.UI.MVVM._PCView.SaveLoad;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._PCView.NewGame {

public class NewGamePhaseSaveInjectorPCView {
    [SerializeField] public object m_Title /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.LevelUp.CharBPortraitChanger m_PortraitChanger /* Kingmaker.UI.LevelUp.CharBPortraitChanger */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.SaveLoad.SaveSlotCollectionVirtualView m_SaveCollectionView /* Kingmaker.UI.MVVM._PCView.SaveLoad.SaveSlotCollectionVirtualView */;
    [SerializeField] public object m_NewCharacterButton /* Owlcat.Runtime.UI.Controls.Button.OwlcatMultiButton */;
    [SerializeField] public object m_NewCharacterButtonTitle /* TMPro.TextMeshProUGUI */;
}

}

