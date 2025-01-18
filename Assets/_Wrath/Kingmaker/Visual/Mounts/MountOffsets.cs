using System;
using UnityEngine;

namespace Kingmaker.Visual.Mounts {

public class MountOffsets : MonoBehaviour {
    [SerializeField] public RaceMountOffsetsConfig OffsetsConfig /* Kingmaker.Visual.Mounts.RaceMountOffsetsConfig */;
    public RaceMountOffsetsConfig MediumOffsetsConfig /* Kingmaker.Visual.Mounts.RaceMountOffsetsConfig */;
    public RaceMountOffsetsConfig LargeOffsetsConfig /* Kingmaker.Visual.Mounts.RaceMountOffsetsConfig */;
    public RaceMountOffsetsConfig HugeOffsetsConfig /* Kingmaker.Visual.Mounts.RaceMountOffsetsConfig */;
    public Transform Root /* UnityEngine.Transform */;
    public Transform RootBattle /* UnityEngine.Transform */;
    public Transform PelvisIkTarget /* UnityEngine.Transform */;
    public Transform LeftFootIkTarget /* UnityEngine.Transform */;
    public Transform LeftKneeIkTarget /* UnityEngine.Transform */;
    public Transform RightFootIkTarget /* UnityEngine.Transform */;
    public Transform RightKneeIkTarget /* UnityEngine.Transform */;
    public Transform Hands /* UnityEngine.Transform */;
    public float PelvisPositionWeight /* System.Single */;
    public float PelvisRotationWeight /* System.Single */;
    public float FootsPositionWeight /* System.Single */;
    public float FootsRotationWeight /* System.Single */;
    public float KneesBendWeight /* System.Single */;
    public float HandsPositionWeight /* System.Single */;
    public float HandsMappingWeight /* System.Single */;
}

}

