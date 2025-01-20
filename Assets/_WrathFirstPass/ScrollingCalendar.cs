using System;
using UnityEngine;
using UnityEngine.UI;

public class ScrollingCalendar : global::UnityEngine.MonoBehaviour {
    public global::UnityEngine.RectTransform monthsScrollingPanel /* UnityEngine.RectTransform */;
    public global::UnityEngine.RectTransform yearsScrollingPanel /* UnityEngine.RectTransform */;
    public global::UnityEngine.RectTransform daysScrollingPanel /* UnityEngine.RectTransform */;
    public global::UnityEngine.GameObject yearsButtonPrefab /* UnityEngine.GameObject */;
    public global::UnityEngine.GameObject monthsButtonPrefab /* UnityEngine.GameObject */;
    public global::UnityEngine.GameObject daysButtonPrefab /* UnityEngine.GameObject */;
    public global::UnityEngine.RectTransform monthCenter /* UnityEngine.RectTransform */;
    public global::UnityEngine.RectTransform yearsCenter /* UnityEngine.RectTransform */;
    public global::UnityEngine.RectTransform daysCenter /* UnityEngine.RectTransform */;
    public global::UnityEngine.UI.InputField inputFieldDays /* UnityEngine.UI.InputField */;
    public global::UnityEngine.UI.InputField inputFieldMonths /* UnityEngine.UI.InputField */;
    public global::UnityEngine.UI.InputField inputFieldYears /* UnityEngine.UI.InputField */;
    public global::UnityEngine.UI.Text dateText /* UnityEngine.UI.Text */;
}

