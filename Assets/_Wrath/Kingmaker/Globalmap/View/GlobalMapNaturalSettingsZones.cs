using System;
using UnityEngine;

namespace Kingmaker.Globalmap.View {

public class GlobalMapNaturalSettingsZones : MonoBehaviour {
    public Transform MapPlane /* UnityEngine.Transform */;
    public float CellSize /* System.Single */;
    [SerializeField] public object m_ZoneCells /* Kingmaker.Enums.GlobalMapZone[] */;
    [SerializeField] public int m_Width /* System.Int32 */;
    [SerializeField] public int m_Height /* System.Int32 */;
    [SerializeField] public float m_MapPlaneWidth /* System.Single */;
    [SerializeField] public float m_MapPlaneHeight /* System.Single */;
}

}

