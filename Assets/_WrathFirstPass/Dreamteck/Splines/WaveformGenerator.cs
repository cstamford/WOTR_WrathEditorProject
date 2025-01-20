using System;
using UnityEngine;

namespace Dreamteck.Splines {

public class WaveformGenerator : global::Dreamteck.Splines.MeshGenerator {
    [SerializeField] public global::Dreamteck.Splines.WaveformGenerator.Axis _axis /* Dreamteck.Splines.Axis */;
    [SerializeField] public bool _symmetry /* System.Boolean */;
    [SerializeField] public global::Dreamteck.Splines.WaveformGenerator.UVWrapMode _uvWrapMode /* Dreamteck.Splines.UVWrapMode */;
    [SerializeField] public int _slices /* System.Int32 */;

    public enum Axis {
        X = 0,
        Y = 1,
        Z = 2,
    }

    public enum UVWrapMode {
        Clamp = 0,
        UniformX = 1,
        UniformY = 2,
        Uniform = 3,
    }

}

}

