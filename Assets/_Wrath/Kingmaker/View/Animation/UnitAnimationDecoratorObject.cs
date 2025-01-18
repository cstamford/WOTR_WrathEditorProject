using System;
using UnityEngine;

namespace Kingmaker.View.Animation {

public class UnitAnimationDecoratorObject : ScriptableObject {
    public bool UseGender /* System.Boolean */;
    public object gender /* Kingmaker.Blueprints.Gender */;
    public float Duration /* System.Single */;
    public object Entries /* Kingmaker.View.Animation.DecoratorEntry[] */;
}

}

