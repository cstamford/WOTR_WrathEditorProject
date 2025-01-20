using System;
using System.Collections.Generic;
using UnityEngine;

public class AkBank {
    public object data /* AK.Wwise.Bank */;
    public bool decodeBank /* System.Boolean */;
    public bool loadAsynchronous /* System.Boolean */;
    public bool saveDecodedBank /* System.Boolean */;
    public global::System.Collections.Generic.List<int> unloadTriggerList /* System.Collections.Generic.List<System.Int32> */;
    [SerializeField] public string bankNameInternal /* System.String */;
    [SerializeField] public byte[] valueGuidInternal /* System.Byte[] */;
}

