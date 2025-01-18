using System;
using System.Collections.Generic;
using UnityEngine;

namespace NobleMuffins.LimbHacker {

public class Hackable : MonoBehaviour {
    public UnityEngine.Object alternatePrefab /* UnityEngine.Object */;
    public Transform[] severables /* UnityEngine.Transform[] */;
    public Dictionary<string, float> maximumTiltBySeverableName /* System.Collections.Generic.Dictionary<System.String, System.Single> */;
    public Material infillMaterial /* UnityEngine.Material */;
    public object infillMode /* NobleMuffins.LimbHacker.Guts.InfillMode */;
}

}

