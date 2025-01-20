using System;
using UnityEngine;

namespace Kingmaker.UI.ActionBar {

public class ActionBarGroupElement : global::UnityEngine.MonoBehaviour {
    public global::UnityEngine.GameObject ActiveHeader /* UnityEngine.GameObject */;
    public global::UnityEngine.GameObject Letter /* UnityEngine.GameObject */;
    public global::UnityEngine.GameObject Arrow /* UnityEngine.GameObject */;
    public global::UnityEngine.CanvasGroup Slots /* UnityEngine.CanvasGroup */;
    public int ShowPosY /* System.Int32 */;
    public int HidePosY /* System.Int32 */;
    public bool PreInit /* System.Boolean */;
    public int MinSlotCount /* System.Int32 */;
    [SerializeField] public global::UnityEngine.RectTransform Background /* UnityEngine.RectTransform */;
    [SerializeField] public global::Kingmaker.UI.ActionBar.ActionBarSubGroupLevels m_Levels /* Kingmaker.UI.ActionBar.ActionBarSubGroupLevels */;
    public object SlotType /* Kingmaker.UI.ActionBar.ActionBarSlotType */;
}

}

