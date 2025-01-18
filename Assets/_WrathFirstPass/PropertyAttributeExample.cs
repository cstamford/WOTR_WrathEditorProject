using System;
using System.Collections.Generic;
using UnityEngine;

public class PropertyAttributeExample : MonoBehaviour {
    public List<PropertyAttributeExample.SimpleObject> simpleObjectsDefaultDisplay /* System.Collections.Generic.List<.SimpleObject> */;
    public List<PropertyAttributeExample.SimpleObject> simpleObjectsUsingTableAttribute /* System.Collections.Generic.List<.SimpleObject> */;
    public List<PropertyAttributeExample.SimpleObject> simpleObjectsUsingReorderableTableAttribute /* System.Collections.Generic.List<.SimpleObject> */;
    public List<Enemy> enemies /* System.Collections.Generic.List<.Enemy> */;

    public class SimpleObject {
        public string stringProperty /* System.String */;
        public float floatProperty /* System.Single */;
        public GameObject objectProperty /* UnityEngine.GameObject */;
        public Vector2 v2Property /* UnityEngine.Vector2 */;
    }

}

