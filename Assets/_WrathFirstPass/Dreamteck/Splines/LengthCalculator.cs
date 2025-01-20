using System;
using UnityEngine;

namespace Dreamteck.Splines {

public class LengthCalculator : global::Dreamteck.Splines.SplineUser {
    public object lengthEvents /* Dreamteck.Splines.LengthEvent[] */;
    public float idealLength /* System.Single */;

    public class LengthEvent {
        public bool enabled /* System.Boolean */;
        public float targetLength /* System.Single */;
        public object action /* Dreamteck.Splines.SplineAction */;
        public global::Dreamteck.Splines.LengthCalculator.LengthEvent.Type type /* Dreamteck.Splines.Type */;

        public enum Type {
            Growing = 0,
            Shrinking = 1,
            Both = 2,
        }

    }

}

}

