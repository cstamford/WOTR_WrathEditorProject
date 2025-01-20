using Kingmaker.UI.Common.Animations;
using System;
using UnityEngine;

namespace Kingmaker.UI.MVVM._PCView.SaveLoad {

public class SaveLoadView {
    [SerializeField] public global::Kingmaker.UI.Common.Animations.FadeAnimator m_FadeAnimator /* Kingmaker.UI.Common.Animations.FadeAnimator */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.SaveLoad.NewSaveSlotView NewSaveSlotView /* Kingmaker.UI.MVVM._PCView.SaveLoad.NewSaveSlotView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.SaveLoad.SaveSlotCollectionVirtualView m_SlotCollectionView /* Kingmaker.UI.MVVM._PCView.SaveLoad.SaveSlotCollectionVirtualView */;
    [SerializeField] public global::Kingmaker.UI.MVVM._PCView.SaveLoad.SaveSlotView m_DetailedSaveSlotView /* Kingmaker.UI.MVVM._PCView.SaveLoad.SaveSlotView */;
}

}

