using UnityEngine;

namespace Kingmaker.UI.Dialog {

public class TempOptionUI : MonoBehaviour {
    public object OptionName /* TMPro.TextMeshProUGUI */;
    public GameObject Arrow /* UnityEngine.GameObject */;
    [SerializeField] public Color m_SelectedColor /* UnityEngine.Color */;
    [SerializeField] public Color m_NormalColor /* UnityEngine.Color */;
    [SerializeField] public Color m_DisableColor /* UnityEngine.Color */;
}

}

