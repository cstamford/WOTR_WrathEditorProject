using System;
using System.Collections.Generic;
using UnityEngine;

public class LogoTable : global::UnityEngine.MonoBehaviour {
    public global::System.Collections.Generic.List<LogoTable.LogoLine> logoLines /* System.Collections.Generic.List<.LogoLine> */;

    public enum LogoLetter {
        T = 0,
        b = 1,
        e = 2,
    }

    public class LogoLine {
        public LogoTable.LogoLetter letter1 /* .LogoLetter */;
        public string letter2 /* System.String */;
        public global::UnityEngine.Color color /* UnityEngine.Color */;
    }

}

