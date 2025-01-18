using System;
using UnityEngine;

namespace Kingmaker.UI.Kingdom {

public class InfoMoveBaseController : MonoBehaviour {
    [SerializeField] public bool m_IsExpandSizeX /* System.Boolean */;
    [SerializeField] public int m_ExpandSizeX /* System.Int32 */;
    [SerializeField] public int m_CollapseSizeX /* System.Int32 */;
    [SerializeField] public float m_MoveTime /* System.Single */;
    public InfoMoveBaseContent Conent /* Kingmaker.UI.Kingdom.InfoMoveBaseContent */;
    [SerializeField] public RectTransform m_SizebleRectTransform /* UnityEngine.RectTransform */;
}

}

