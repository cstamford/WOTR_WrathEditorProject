using System;
using UnityEngine;

namespace Kingmaker.Visual.CharacterSystem.Dismemberment {

public class DismembermentBatchSliceConfig : ScriptableObject {
    public string[] IncludePaths /* System.String[] */;
    public string[] ExcludePaths /* System.String[] */;
    public string[] IncludeOnlyCharacters /* System.String[] */;
    public string[] SkipCharacters /* System.String[] */;
    public bool RebakeOnlyBroken /* System.Boolean */;
    public string[] BrokenCharacters /* System.String[] */;
    public DismembermentTemplate DismembermentTemplateMale /* Kingmaker.Visual.CharacterSystem.Dismemberment.DismembermentTemplate */;
    public DismembermentTemplate DismembermentTemplateFemale /* Kingmaker.Visual.CharacterSystem.Dismemberment.DismembermentTemplate */;
}

}

