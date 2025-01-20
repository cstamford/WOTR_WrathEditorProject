using System;
using System.Collections.Generic;
using UnityEngine;

namespace Dreamteck.Splines {

public class SplineMesh : global::Dreamteck.Splines.MeshGenerator {
    [SerializeField] public global::System.Collections.Generic.List<global::Dreamteck.Splines.SplineMesh.Channel> channels /* System.Collections.Generic.List<Dreamteck.Splines.Channel> */;

    public class Channel {
        public string name /* System.String */;
        [SerializeField] public int _iterationSeed /* System.Int32 */;
        [SerializeField] public int _offsetSeed /* System.Int32 */;
        [SerializeField] public int _rotationSeed /* System.Int32 */;
        [SerializeField] public int _scaleSeed /* System.Int32 */;
        [SerializeField] public global::Dreamteck.Splines.SplineMesh owner /* Dreamteck.Splines.SplineMesh */;
        [SerializeField] public global::System.Collections.Generic.List<global::Dreamteck.Splines.SplineMesh.Channel.MeshDefinition> meshes /* System.Collections.Generic.List<Dreamteck.Splines.MeshDefinition> */;
        [SerializeField] public double _clipFrom /* System.Double */;
        [SerializeField] public double _clipTo /* System.Double */;
        [SerializeField] public bool _randomOrder /* System.Boolean */;
        [SerializeField] public global::Dreamteck.Splines.SplineMesh.Channel.UVOverride _overrideUVs /* Dreamteck.Splines.UVOverride */;
        [SerializeField] public global::UnityEngine.Vector2 _uvScale /* UnityEngine.Vector2 */;
        [SerializeField] public global::UnityEngine.Vector2 _uvOffset /* UnityEngine.Vector2 */;
        [SerializeField] public bool _overrideNormal /* System.Boolean */;
        [SerializeField] public global::UnityEngine.Vector3 _customNormal /* UnityEngine.Vector3 */;
        [SerializeField] public global::Dreamteck.Splines.SplineMesh.Channel.Type _type /* Dreamteck.Splines.Type */;
        [SerializeField] public int _count /* System.Int32 */;
        [SerializeField] public double _spacing /* System.Double */;
        [SerializeField] public bool _randomRotation /* System.Boolean */;
        [SerializeField] public global::UnityEngine.Vector3 _minRotation /* UnityEngine.Vector3 */;
        [SerializeField] public global::UnityEngine.Vector3 _maxRotation /* UnityEngine.Vector3 */;
        [SerializeField] public bool _randomOffset /* System.Boolean */;
        [SerializeField] public global::UnityEngine.Vector2 _minOffset /* UnityEngine.Vector2 */;
        [SerializeField] public global::UnityEngine.Vector2 _maxOffset /* UnityEngine.Vector2 */;
        [SerializeField] public bool _randomScale /* System.Boolean */;
        [SerializeField] public bool _uniformRandomScale /* System.Boolean */;
        [SerializeField] public global::UnityEngine.Vector3 _minScale /* UnityEngine.Vector3 */;
        [SerializeField] public global::UnityEngine.Vector3 _maxScale /* UnityEngine.Vector3 */;
        [SerializeField] public bool _overrideMaterialID /* System.Boolean */;
        [SerializeField] public int _targetMaterialID /* System.Int32 */;

        public enum Type {
            Extrude = 0,
            Place = 1,
        }

        public enum UVOverride {
            None = 0,
            ClampU = 1,
            ClampV = 2,
            UniformU = 3,
            UniformV = 4,
        }

        public class MeshDefinition {
            [SerializeField] public global::UnityEngine.Vector3[] vertices /* UnityEngine.Vector3[] */;
            [SerializeField] public global::UnityEngine.Vector3[] normals /* UnityEngine.Vector3[] */;
            [SerializeField] public global::UnityEngine.Vector4[] tangents /* UnityEngine.Vector4[] */;
            [SerializeField] public global::UnityEngine.Color[] colors /* UnityEngine.Color[] */;
            [SerializeField] public global::UnityEngine.Vector2[] uv /* UnityEngine.Vector2[] */;
            [SerializeField] public global::UnityEngine.Vector2[] uv2 /* UnityEngine.Vector2[] */;
            [SerializeField] public global::UnityEngine.Vector2[] uv3 /* UnityEngine.Vector2[] */;
            [SerializeField] public global::UnityEngine.Vector2[] uv4 /* UnityEngine.Vector2[] */;
            [SerializeField] public int[] triangles /* System.Int32[] */;
            [SerializeField] public global::System.Collections.Generic.List<global::Dreamteck.Splines.SplineMesh.Channel.MeshDefinition.Submesh> subMeshes /* System.Collections.Generic.List<Dreamteck.Splines.Submesh> */;
            [SerializeField] public object bounds /* Dreamteck.TS_Bounds */;
            [SerializeField] public global::System.Collections.Generic.List<global::Dreamteck.Splines.SplineMesh.Channel.MeshDefinition.VertexGroup> vertexGroups /* System.Collections.Generic.List<Dreamteck.Splines.VertexGroup> */;
            [SerializeField] public global::UnityEngine.Mesh _mesh /* UnityEngine.Mesh */;
            [SerializeField] public global::UnityEngine.Vector3 _rotation /* UnityEngine.Vector3 */;
            [SerializeField] public global::UnityEngine.Vector2 _offset /* UnityEngine.Vector2 */;
            [SerializeField] public global::UnityEngine.Vector3 _scale /* UnityEngine.Vector3 */;
            [SerializeField] public global::UnityEngine.Vector2 _uvScale /* UnityEngine.Vector2 */;
            [SerializeField] public global::UnityEngine.Vector2 _uvOffset /* UnityEngine.Vector2 */;
            [SerializeField] public float _uvRotation /* System.Single */;
            [SerializeField] public global::Dreamteck.Splines.SplineMesh.Channel.MeshDefinition.MirrorMethod _mirror /* Dreamteck.Splines.MirrorMethod */;
            [SerializeField] public bool _flipFaces /* System.Boolean */;
            [SerializeField] public bool _doubleSided /* System.Boolean */;

            public enum MirrorMethod {
                None = 0,
                X = 1,
                Y = 2,
                Z = 3,
            }

            public class Submesh {
                public int[] triangles /* System.Int32[] */;
            }

            public class VertexGroup {
                public float value /* System.Single */;
                public double percent /* System.Double */;
                public int[] ids /* System.Int32[] */;
            }

        }

    }

}

}

