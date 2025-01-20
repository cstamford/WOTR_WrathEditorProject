using System;
using UnityEngine;

namespace NobleMuffins.LimbHacker {

public class ToRagdollOrNot {
    public global::NobleMuffins.LimbHacker.ToRagdollOrNot.Operator groupRule /* NobleMuffins.LimbHacker.Operator */;
    public global::NobleMuffins.LimbHacker.ToRagdollOrNot.Presentness totalityRule /* NobleMuffins.LimbHacker.Presentness */;
    public global::UnityEngine.Transform[] bones /* UnityEngine.Transform[] */;

    public enum Operator {
        And = 0,
        Or = 1,
    }

    public enum Presentness {
        Equals = 0,
        Not = 1,
    }

}

}

