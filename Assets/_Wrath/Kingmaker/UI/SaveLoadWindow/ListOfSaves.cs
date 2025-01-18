using UnityEngine;

namespace Kingmaker.UI.SaveLoadWindow {

public class ListOfSaves : MonoBehaviour {
    [SerializeField] public object m_Slot /* Kingmaker.UI.SaveLoadWindow.SaveSlotBase */;
    [SerializeField] public RootSaveSlot m_RootSave /* Kingmaker.UI.SaveLoadWindow.RootSaveSlot */;
    [SerializeField] public RectTransform m_Container /* UnityEngine.RectTransform */;
}

}

