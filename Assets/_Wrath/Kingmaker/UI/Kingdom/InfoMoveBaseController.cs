using System;
using UnityEngine;

namespace Kingmaker.UI.Kingdom {

public class InfoMoveBaseController : global::UnityEngine.MonoBehaviour {
    [SerializeField] public bool m_IsExpandSizeX /* System.Boolean */;
    [SerializeField] public int m_ExpandSizeX /* System.Int32 */;
    [SerializeField] public int m_CollapseSizeX /* System.Int32 */;
    [SerializeField] public float m_MoveTime /* System.Single */;
    public global::Kingmaker.UI.Kingdom.InfoMoveBaseContent Conent /* Kingmaker.UI.Kingdom.InfoMoveBaseContent */;
    [SerializeField] public global::UnityEngine.RectTransform m_SizebleRectTransform /* UnityEngine.RectTransform */;
}

}

