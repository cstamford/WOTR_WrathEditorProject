using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class LayoutRedirectElement {
    [SerializeField] public UnityEngine.Object m_Source /* UnityEngine.Object */;
    [SerializeField] public LayoutRedirectElement.Source m_MinWidth /* .Source */;
    [SerializeField] public LayoutRedirectElement.Source m_MinHeight /* .Source */;
    [SerializeField] public LayoutRedirectElement.Source m_PreferredWidth /* .Source */;
    [SerializeField] public LayoutRedirectElement.Source m_PreferredHeight /* .Source */;
    [SerializeField] public int m_LayoutPriority /* System.Int32 */;

    public enum Source {
        None = 0,
        Min = 1,
        Prefered = 2,
    }

}

