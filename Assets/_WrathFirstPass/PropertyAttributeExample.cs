using System;
using System.Collections.Generic;
using UnityEngine;

public class PropertyAttributeExample : global::UnityEngine.MonoBehaviour {
    public global::System.Collections.Generic.List<PropertyAttributeExample.SimpleObject> simpleObjectsDefaultDisplay /* System.Collections.Generic.List<.SimpleObject> */;
    public global::System.Collections.Generic.List<PropertyAttributeExample.SimpleObject> simpleObjectsUsingTableAttribute /* System.Collections.Generic.List<.SimpleObject> */;
    public global::System.Collections.Generic.List<PropertyAttributeExample.SimpleObject> simpleObjectsUsingReorderableTableAttribute /* System.Collections.Generic.List<.SimpleObject> */;
    public global::System.Collections.Generic.List<Enemy> enemies /* System.Collections.Generic.List<.Enemy> */;

    public class SimpleObject {
        public string stringProperty /* System.String */;
        public float floatProperty /* System.Single */;
        public global::UnityEngine.GameObject objectProperty /* UnityEngine.GameObject */;
        public global::UnityEngine.Vector2 v2Property /* UnityEngine.Vector2 */;
    }

}

