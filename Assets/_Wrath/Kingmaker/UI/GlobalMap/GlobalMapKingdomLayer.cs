using Kingmaker.Kingdom;
using Kingmaker.Visual.Kingdom;
using System;
using UnityEngine;

namespace Kingmaker.UI.GlobalMap {

public class GlobalMapKingdomLayer : MonoBehaviour {
    [SerializeField] public BorderGlowHighlighter m_BorderGlowHighlighter /* Kingmaker.Visual.Kingdom.BorderGlowHighlighter */;
    [SerializeField] public Transform m_BordersContainer /* UnityEngine.Transform */;
    [SerializeField] public Transform m_RegionsContainer /* UnityEngine.Transform */;
    [SerializeField] public RegionObject m_TerraIncognita /* Kingmaker.Kingdom.RegionObject */;
    public Color ClaimColor /* UnityEngine.Color */;
    public Color UnclaimColor /* UnityEngine.Color */;
    public float BaseWidth /* System.Single */;
}

}

