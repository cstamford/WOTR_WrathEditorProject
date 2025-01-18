using System.Collections.Generic;
using UnityEngine;

namespace Kingmaker.UI.Kingdom {

public class BaseNaviElement : MonoBehaviour {
    public GameObject DefaultLayer /* UnityEngine.GameObject */;
    public GameObject ActiveLayer /* UnityEngine.GameObject */;
    public object Label /* TMPro.TextMeshProUGUI */;
    public Color SelectColor /* UnityEngine.Color */;
    public Color NormalColor /* UnityEngine.Color */;
    public List<GameObject> Fxs /* System.Collections.Generic.List<UnityEngine.GameObject> */;
}

}

