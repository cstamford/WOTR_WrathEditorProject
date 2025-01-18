using System;
using UnityEngine;

public class AkEnvironment : MonoBehaviour {
    public bool excludeOthers /* System.Boolean */;
    public bool isDefault /* System.Boolean */;
    public object data /* AK.Wwise.AuxBus */;
    public int priority /* System.Int32 */;
    [SerializeField] public int auxBusIdInternal /* System.Int32 */;
    [SerializeField] public byte[] valueGuidInternal /* System.Byte[] */;

    public class AkEnvironment_CompareByPriority {
    }

}

