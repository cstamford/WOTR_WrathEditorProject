using System;
using System.Collections.Generic;
using UnityEngine;

public class AdvancedExample : global::UnityEngine.MonoBehaviour {
    public global::System.Collections.Generic.List<Enemy> enemies /* System.Collections.Generic.List<.Enemy> */;
    public global::System.Collections.Generic.List<AdvancedExample.IntroSentence> introSentences /* System.Collections.Generic.List<.IntroSentence> */;
    public global::System.Collections.Generic.List<AdvancedExample.Spawner> spawners /* System.Collections.Generic.List<.Spawner> */;

    public class IntroSentence {
        public object enemyType /* .EnemyType */;
        public string sentence /* System.String */;
    }

    public class Spawner {
        public string name /* System.String */;
        public global::UnityEngine.Vector2 position /* UnityEngine.Vector2 */;
    }

}

