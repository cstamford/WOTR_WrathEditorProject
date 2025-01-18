using System;
using UnityEngine;

namespace Kingmaker.UI.ActionBar {

public class ActionBarGroupElement : MonoBehaviour {
    public GameObject ActiveHeader /* UnityEngine.GameObject */;
    public GameObject Letter /* UnityEngine.GameObject */;
    public GameObject Arrow /* UnityEngine.GameObject */;
    public CanvasGroup Slots /* UnityEngine.CanvasGroup */;
    public int ShowPosY /* System.Int32 */;
    public int HidePosY /* System.Int32 */;
    public bool PreInit /* System.Boolean */;
    public int MinSlotCount /* System.Int32 */;
    [SerializeField] public RectTransform Background /* UnityEngine.RectTransform */;
    [SerializeField] public ActionBarSubGroupLevels m_Levels /* Kingmaker.UI.ActionBar.ActionBarSubGroupLevels */;
    public object SlotType /* Kingmaker.UI.ActionBar.ActionBarSlotType */;
}

}

