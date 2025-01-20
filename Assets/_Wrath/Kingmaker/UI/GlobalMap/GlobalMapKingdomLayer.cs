using Kingmaker.Kingdom;
using Kingmaker.Visual.Kingdom;
using System;
using UnityEngine;

namespace Kingmaker.UI.GlobalMap {

public class GlobalMapKingdomLayer : global::UnityEngine.MonoBehaviour {
    [SerializeField] public global::Kingmaker.Visual.Kingdom.BorderGlowHighlighter m_BorderGlowHighlighter /* Kingmaker.Visual.Kingdom.BorderGlowHighlighter */;
    [SerializeField] public global::UnityEngine.Transform m_BordersContainer /* UnityEngine.Transform */;
    [SerializeField] public global::UnityEngine.Transform m_RegionsContainer /* UnityEngine.Transform */;
    [SerializeField] public global::Kingmaker.Kingdom.RegionObject m_TerraIncognita /* Kingmaker.Kingdom.RegionObject */;
    public global::UnityEngine.Color ClaimColor /* UnityEngine.Color */;
    public global::UnityEngine.Color UnclaimColor /* UnityEngine.Color */;
    public float BaseWidth /* System.Single */;
}

}

