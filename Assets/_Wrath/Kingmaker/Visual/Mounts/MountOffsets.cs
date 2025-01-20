using System;
using UnityEngine;

namespace Kingmaker.Visual.Mounts {

public class MountOffsets : global::UnityEngine.MonoBehaviour {
    [SerializeField] public global::Kingmaker.Visual.Mounts.RaceMountOffsetsConfig OffsetsConfig /* Kingmaker.Visual.Mounts.RaceMountOffsetsConfig */;
    public global::Kingmaker.Visual.Mounts.RaceMountOffsetsConfig MediumOffsetsConfig /* Kingmaker.Visual.Mounts.RaceMountOffsetsConfig */;
    public global::Kingmaker.Visual.Mounts.RaceMountOffsetsConfig LargeOffsetsConfig /* Kingmaker.Visual.Mounts.RaceMountOffsetsConfig */;
    public global::Kingmaker.Visual.Mounts.RaceMountOffsetsConfig HugeOffsetsConfig /* Kingmaker.Visual.Mounts.RaceMountOffsetsConfig */;
    public global::UnityEngine.Transform Root /* UnityEngine.Transform */;
    public global::UnityEngine.Transform RootBattle /* UnityEngine.Transform */;
    public global::UnityEngine.Transform PelvisIkTarget /* UnityEngine.Transform */;
    public global::UnityEngine.Transform LeftFootIkTarget /* UnityEngine.Transform */;
    public global::UnityEngine.Transform LeftKneeIkTarget /* UnityEngine.Transform */;
    public global::UnityEngine.Transform RightFootIkTarget /* UnityEngine.Transform */;
    public global::UnityEngine.Transform RightKneeIkTarget /* UnityEngine.Transform */;
    public global::UnityEngine.Transform Hands /* UnityEngine.Transform */;
    public float PelvisPositionWeight /* System.Single */;
    public float PelvisRotationWeight /* System.Single */;
    public float FootsPositionWeight /* System.Single */;
    public float FootsRotationWeight /* System.Single */;
    public float KneesBendWeight /* System.Single */;
    public float HandsPositionWeight /* System.Single */;
    public float HandsMappingWeight /* System.Single */;
}

}

