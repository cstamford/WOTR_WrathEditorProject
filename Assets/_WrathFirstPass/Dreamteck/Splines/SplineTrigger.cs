using System;
using UnityEngine;

namespace Dreamteck.Splines {

public class SplineTrigger : ScriptableObject {
    [SerializeField] public SplineTrigger.Type type /* Dreamteck.Splines.Type */;
    public double position /* System.Double */;
    [SerializeField] public bool enabled /* System.Boolean */;
    [SerializeField] public Color color /* UnityEngine.Color */;
    [SerializeField] public object actions /* Dreamteck.Splines.SplineAction[] */;
    public GameObject[] gameObjects /* UnityEngine.GameObject[] */;

    public enum Type {
        Double = 0,
        Forward = 1,
        Backward = 2,
    }

}

}

