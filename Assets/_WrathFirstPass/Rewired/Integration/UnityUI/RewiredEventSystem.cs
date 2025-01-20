using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Rewired.Integration.UnityUI {

public class RewiredEventSystem : global::UnityEngine.EventSystems.EventSystem {
    [SerializeField] public bool _alwaysUpdate /* System.Boolean */;
}

}

