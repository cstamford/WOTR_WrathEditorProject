using System;
using UnityEngine;

namespace Kingmaker.UI.GlobalMap {

public class GlobalMapLocalMapManager : global::UnityEngine.MonoBehaviour {
    [SerializeField] public global::Kingmaker.UI.GlobalMap.GlobalMapLocalMapController m_Controller /* Kingmaker.UI.GlobalMap.GlobalMapLocalMapController */;
    [SerializeField] public int m_ShowPosX /* System.Int32 */;
    [SerializeField] public int m_HidePosX /* System.Int32 */;
    [SerializeField] public global::UnityEngine.GameObject m_ToggleArrowOpen /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.GameObject m_ToggleArrowClose /* UnityEngine.GameObject */;
    [SerializeField] public bool m_IsKenabres /* System.Boolean */;
}

}

