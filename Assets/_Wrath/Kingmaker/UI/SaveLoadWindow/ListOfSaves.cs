using System;
using UnityEngine;

namespace Kingmaker.UI.SaveLoadWindow {

public class ListOfSaves : global::UnityEngine.MonoBehaviour {
    [SerializeField] public global::Kingmaker.UI.SaveLoadWindow.SaveSlotBase m_Slot /* Kingmaker.UI.SaveLoadWindow.SaveSlotBase */;
    [SerializeField] public global::Kingmaker.UI.SaveLoadWindow.RootSaveSlot m_RootSave /* Kingmaker.UI.SaveLoadWindow.RootSaveSlot */;
    [SerializeField] public global::UnityEngine.RectTransform m_Container /* UnityEngine.RectTransform */;
}

}

