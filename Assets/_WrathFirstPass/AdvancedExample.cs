using System;
using System.Collections.Generic;
using UnityEngine;

public class AdvancedExample : MonoBehaviour {
    public List<Enemy> enemies /* System.Collections.Generic.List<.Enemy> */;
    public List<AdvancedExample.IntroSentence> introSentences /* System.Collections.Generic.List<.IntroSentence> */;
    public List<AdvancedExample.Spawner> spawners /* System.Collections.Generic.List<.Spawner> */;

    public class IntroSentence {
        public object enemyType /* .EnemyType */;
        public string sentence /* System.String */;
    }

    public class Spawner {
        public string name /* System.String */;
        public Vector2 position /* UnityEngine.Vector2 */;
    }

}

