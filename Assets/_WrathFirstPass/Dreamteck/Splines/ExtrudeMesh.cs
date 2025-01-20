using System;
using System.Collections.Generic;
using UnityEngine;

namespace Dreamteck.Splines {

public class ExtrudeMesh : global::Dreamteck.Splines.MeshGenerator {
    [SerializeField] public global::UnityEngine.Mesh _startMesh /* UnityEngine.Mesh */;
    [SerializeField] public global::UnityEngine.Mesh _endMesh /* UnityEngine.Mesh */;
    [SerializeField] public bool _dontStretchCaps /* System.Boolean */;
    [SerializeField] public global::Dreamteck.Splines.ExtrudeMesh.TileUVs _tileUVs /* Dreamteck.Splines.TileUVs */;
    [SerializeField] public global::UnityEngine.Mesh[] _middleMeshes /* UnityEngine.Mesh[] */;
    [SerializeField] public global::System.Collections.Generic.List<global::Dreamteck.Splines.ExtrudeMesh.ExtrudableMesh> extrudableMeshes /* System.Collections.Generic.List<Dreamteck.Splines.ExtrudableMesh> */;
    [SerializeField] public global::Dreamteck.Splines.ExtrudeMesh.Axis _axis /* Dreamteck.Splines.Axis */;
    [SerializeField] public global::Dreamteck.Splines.ExtrudeMesh.Iteration _iteration /* Dreamteck.Splines.Iteration */;
    [SerializeField] public int _randomSeed /* System.Int32 */;
    [SerializeField] public int _repeat /* System.Int32 */;
    [SerializeField] public double _spacing /* System.Double */;
    [SerializeField] public global::UnityEngine.Vector2 _scale /* UnityEngine.Vector2 */;

    public enum Axis {
        X = 0,
        Y = 1,
        Z = 2,
    }

    public enum Iteration {
        Ordered = 0,
        Random = 1,
    }

    public enum MirrorMethod {
        None = 0,
        X = 1,
        Y = 2,
        Z = 3,
    }

    public enum TileUVs {
        None = 0,
        U = 1,
        V = 2,
        UniformU = 3,
        UniformV = 4,
    }

    public class ExtrudableMesh {
        public global::UnityEngine.Vector3[] vertices /* UnityEngine.Vector3[] */;
        public global::UnityEngine.Vector3[] normals /* UnityEngine.Vector3[] */;
        public global::UnityEngine.Vector4[] tangents /* UnityEngine.Vector4[] */;
        public global::UnityEngine.Color[] colors /* UnityEngine.Color[] */;
        public global::UnityEngine.Vector2[] uv /* UnityEngine.Vector2[] */;
        public global::System.Collections.Generic.List<global::Dreamteck.Splines.ExtrudeMesh.ExtrudableMesh.Submesh> subMeshes /* System.Collections.Generic.List<Dreamteck.Splines.Submesh> */;
        public object bounds /* Dreamteck.TS_Bounds */;
        public global::System.Collections.Generic.List<global::Dreamteck.Splines.ExtrudeMesh.ExtrudableMesh.VertexGroup> vertexGroups /* System.Collections.Generic.List<Dreamteck.Splines.VertexGroup> */;
        [SerializeField] public global::Dreamteck.Splines.ExtrudeMesh.MirrorMethod _mirror /* Dreamteck.Splines.MirrorMethod */;
        [SerializeField] public global::Dreamteck.Splines.ExtrudeMesh.Axis _axis /* Dreamteck.Splines.Axis */;

        public class VertexGroup {
            public float value /* System.Single */;
            public int[] ids /* System.Int32[] */;
        }

        public class Submesh {
            public int[] triangles /* System.Int32[] */;
        }

    }

}

}

