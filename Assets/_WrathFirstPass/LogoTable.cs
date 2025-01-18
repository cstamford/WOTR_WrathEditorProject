using System;
using System.Collections.Generic;
using UnityEngine;

public class LogoTable : MonoBehaviour {
    public List<LogoTable.LogoLine> logoLines /* System.Collections.Generic.List<.LogoLine> */;

    public enum LogoLetter {
        T = 0,
        b = 1,
        e = 2,
    }

    public class LogoLine {
        public LogoTable.LogoLetter letter1 /* .LogoLetter */;
        public string letter2 /* System.String */;
        public Color color /* UnityEngine.Color */;
    }

}

