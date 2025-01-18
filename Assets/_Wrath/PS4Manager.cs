using System;
using System.Collections.Generic;
using UnityEngine;

public class PS4Manager : MonoBehaviour {
    public List<PS4Manager.DlcContent> m_DlcContents /* System.Collections.Generic.List<.DlcContent> */;
    public bool CanListenEntitlements /* System.Boolean */;

    public class DlcContent {
        public int ServiceLabel /* System.Int32 */;
        public string EntitlementLabel /* System.String */;
        public string[] FilePaths /* System.String[] */;
        public bool Purchased /* System.Boolean */;
        public bool Mounted /* System.Boolean */;
    }

}

