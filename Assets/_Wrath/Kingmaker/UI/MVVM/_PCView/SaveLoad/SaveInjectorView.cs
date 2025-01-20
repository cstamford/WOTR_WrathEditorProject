using Kingmaker.UI.LevelUp;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._PCView.SaveLoad {

public class SaveInjectorView {
    [SerializeField] public object m_Title /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::Kingmaker.UI.LevelUp.CharBPortraitChanger m_PortraitChanger /* Kingmaker.UI.LevelUp.CharBPortraitChanger */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.SaveLoad.SaveSlotCollectionVirtualView m_SaveCollectionView /* Kingmaker.UI.MVVM._PCView.SaveLoad.SaveSlotCollectionVirtualView */;
}

}

