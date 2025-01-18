using System;
using UnityEngine;

namespace Owlcat.Runtime.Visual.RenderPipeline.GPUSkinning {

public class GPUSkinningClip : ScriptableObject {
    public AnimationClip Clip /* UnityEngine.AnimationClip */;
    public GameObject AnimatorPrefab /* UnityEngine.GameObject */;
    public int BakeFPS /* System.Int32 */;
    public object Data /* Owlcat.Runtime.Visual.RenderPipeline.GPUSkinning.GPUSkinningClipData */;
}

}

