using System;
using UnityEngine;

namespace Kingmaker.UI.GlobalMap {

public class GlobalMapLocalMapManager : MonoBehaviour {
    [SerializeField] public GlobalMapLocalMapController m_Controller /* Kingmaker.UI.GlobalMap.GlobalMapLocalMapController */;
    [SerializeField] public int m_ShowPosX /* System.Int32 */;
    [SerializeField] public int m_HidePosX /* System.Int32 */;
    [SerializeField] public GameObject m_ToggleArrowOpen /* UnityEngine.GameObject */;
    [SerializeField] public GameObject m_ToggleArrowClose /* UnityEngine.GameObject */;
    [SerializeField] public bool m_IsKenabres /* System.Boolean */;
}

}

