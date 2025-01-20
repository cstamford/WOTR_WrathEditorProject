using System;
using UnityEngine;

namespace Kingmaker.Visual.CharacterSystem.Dismemberment {

public class DismembermentBatchSliceConfig : global::UnityEngine.ScriptableObject {
    public string[] IncludePaths /* System.String[] */;
    public string[] ExcludePaths /* System.String[] */;
    public string[] IncludeOnlyCharacters /* System.String[] */;
    public string[] SkipCharacters /* System.String[] */;
    public bool RebakeOnlyBroken /* System.Boolean */;
    public string[] BrokenCharacters /* System.String[] */;
    public global::Kingmaker.Visual.CharacterSystem.Dismemberment.DismembermentTemplate DismembermentTemplateMale /* Kingmaker.Visual.CharacterSystem.Dismemberment.DismembermentTemplate */;
    public global::Kingmaker.Visual.CharacterSystem.Dismemberment.DismembermentTemplate DismembermentTemplateFemale /* Kingmaker.Visual.CharacterSystem.Dismemberment.DismembermentTemplate */;
}

}

