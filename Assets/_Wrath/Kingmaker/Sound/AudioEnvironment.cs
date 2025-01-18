using System;
using UnityEngine;

namespace Kingmaker.Sound {

public class AudioEnvironment : MonoBehaviour {
    public bool ExcludeOthers /* System.Boolean */;
    public bool IsDefault /* System.Boolean */;
    public object Bus /* Kingmaker.Sound.AkAuxBusReference */;
    public int Priority /* System.Int32 */;

    public class CompareByPriorityComparer {
    }

}

}

