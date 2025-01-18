using System;
using System.Collections.Generic;
using UnityEngine;

public class ActionExample : MonoBehaviour {
    public List<ActionExample.SimpleObject> simpleObjects /* System.Collections.Generic.List<.SimpleObject> */;

    public class SimpleObject {
        public string stringProperty /* System.String */;
        public float floatProperty /* System.Single */;
        public GameObject objectProperty /* UnityEngine.GameObject */;
    }

}

