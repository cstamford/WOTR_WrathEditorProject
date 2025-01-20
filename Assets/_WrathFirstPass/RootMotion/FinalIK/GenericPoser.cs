using System;
using UnityEngine;

namespace RootMotion.FinalIK {

public class GenericPoser {
    public object maps /* RootMotion.FinalIK.Map[] */;

    public class Map {
        public global::UnityEngine.Transform bone /* UnityEngine.Transform */;
        public global::UnityEngine.Transform target /* UnityEngine.Transform */;
    }

}

}

