using System;
using UnityEngine;

namespace Dreamteck.Splines {

public class ObjectController : global::Dreamteck.Splines.SplineUser {
    [SerializeField] public global::UnityEngine.GameObject[] objects /* UnityEngine.GameObject[] */;
    [SerializeField] public float _positionOffset /* System.Single */;
    [SerializeField] public int _spawnCount /* System.Int32 */;
    [SerializeField] public global::Dreamteck.Splines.ObjectController.Positioning _objectPositioning /* Dreamteck.Splines.Positioning */;
    [SerializeField] public global::Dreamteck.Splines.ObjectController.Iteration _iteration /* Dreamteck.Splines.Iteration */;
    [SerializeField] public int _randomSeed /* System.Int32 */;
    [SerializeField] public global::UnityEngine.Vector2 _randomSize /* UnityEngine.Vector2 */;
    [SerializeField] public global::UnityEngine.Vector3 _offset /* UnityEngine.Vector3 */;
    [SerializeField] public bool _offsetUseWorldCoords /* System.Boolean */;
    [SerializeField] public global::UnityEngine.Vector3 _minRotationOffset /* UnityEngine.Vector3 */;
    [SerializeField] public global::UnityEngine.Vector3 _maxRotationOffset /* UnityEngine.Vector3 */;
    [SerializeField] public global::UnityEngine.Vector3 _minScaleMultiplier /* UnityEngine.Vector3 */;
    [SerializeField] public global::UnityEngine.Vector3 _maxScaleMultiplier /* UnityEngine.Vector3 */;
    [SerializeField] public bool _randomizeOffset /* System.Boolean */;
    [SerializeField] public bool _useRandomOffsetRotation /* System.Boolean */;
    [SerializeField] public bool _shellOffset /* System.Boolean */;
    [SerializeField] public bool _randomOffset /* System.Boolean */;
    [SerializeField] public bool _applyRotation /* System.Boolean */;
    [SerializeField] public bool _applyScale /* System.Boolean */;
    [SerializeField] public global::Dreamteck.Splines.ObjectController.ObjectMethod _objectMethod /* Dreamteck.Splines.ObjectMethod */;
    public bool delayedSpawn /* System.Boolean */;
    public float spawnDelay /* System.Single */;
    [SerializeField] public int lastChildCount /* System.Int32 */;
    [SerializeField] public object spawned /* Dreamteck.Splines.ObjectControl[] */;

    public class ObjectControl {
        public global::UnityEngine.GameObject gameObject /* UnityEngine.GameObject */;
        public global::UnityEngine.Vector3 position /* UnityEngine.Vector3 */;
        public global::UnityEngine.Quaternion rotation /* UnityEngine.Quaternion */;
        public global::UnityEngine.Vector3 scale /* UnityEngine.Vector3 */;
        public bool active /* System.Boolean */;
        public global::UnityEngine.Vector3 baseScale /* UnityEngine.Vector3 */;
    }

    public enum ObjectMethod {
        Instantiate = 0,
        GetChildren = 1,
    }

    public enum Positioning {
        Stretch = 0,
        Clip = 1,
    }

    public enum Iteration {
        Ordered = 0,
        Random = 1,
    }

}

}

