using UnityEngine;
using UnityEngine.UI;

public class ScrollingCalendar : MonoBehaviour {
    public RectTransform monthsScrollingPanel /* UnityEngine.RectTransform */;
    public RectTransform yearsScrollingPanel /* UnityEngine.RectTransform */;
    public RectTransform daysScrollingPanel /* UnityEngine.RectTransform */;
    public GameObject yearsButtonPrefab /* UnityEngine.GameObject */;
    public GameObject monthsButtonPrefab /* UnityEngine.GameObject */;
    public GameObject daysButtonPrefab /* UnityEngine.GameObject */;
    public RectTransform monthCenter /* UnityEngine.RectTransform */;
    public RectTransform yearsCenter /* UnityEngine.RectTransform */;
    public RectTransform daysCenter /* UnityEngine.RectTransform */;
    public InputField inputFieldDays /* UnityEngine.UI.InputField */;
    public InputField inputFieldMonths /* UnityEngine.UI.InputField */;
    public InputField inputFieldYears /* UnityEngine.UI.InputField */;
    public Text dateText /* UnityEngine.UI.Text */;
}

