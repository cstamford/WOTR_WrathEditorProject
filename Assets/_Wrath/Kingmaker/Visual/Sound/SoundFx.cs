using System;
using UnityEngine;

namespace Kingmaker.Visual.Sound {

public class SoundFx : MonoBehaviour {
    public object EventsOnStart /* Kingmaker.Visual.Sound.SlotType[] */;
    public object EventsOnDestroy /* Kingmaker.Visual.Sound.SlotType[] */;
    public SoundFx Prefab /* Kingmaker.Visual.Sound.SoundFx */;

    public class SlotType {
        public string Event /* System.String */;
        public float Gain /* System.Single */;
        public float Pitch /* System.Single */;
        public float Delay /* System.Single */;
        public bool SkipIfLoading /* System.Boolean */;
    }

}

}

