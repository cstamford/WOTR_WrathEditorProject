using System;
using System.Collections.Generic;
using UnityEngine;

public class SimpleExample : MonoBehaviour {
    public List<SimpleExample.SimpleObject> simpleObjects /* System.Collections.Generic.List<.SimpleObject> */;

    public class SimpleObject {
        public string stringProperty /* System.String */;
        public float floatProperty /* System.Single */;
        public GameObject objectProperty /* UnityEngine.GameObject */;
    }

}

