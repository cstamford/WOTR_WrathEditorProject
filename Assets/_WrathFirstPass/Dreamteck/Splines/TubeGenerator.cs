using System;
using UnityEngine;

namespace Dreamteck.Splines {

public class TubeGenerator : global::Dreamteck.Splines.MeshGenerator {
    [SerializeField] public int _sides /* System.Int32 */;
    [SerializeField] public int _roundCapLatitude /* System.Int32 */;
    [SerializeField] public global::Dreamteck.Splines.TubeGenerator.CapMethod _capMode /* Dreamteck.Splines.CapMethod */;
    [SerializeField] public float _integrity /* System.Single */;
    [SerializeField] public float _capUVScale /* System.Single */;

    public enum CapMethod {
        None = 0,
        Flat = 1,
        Round = 2,
    }

}

}

