using System;
using UnityEngine;

namespace Kingmaker.Visual.CharacterSystem {

public class CharacterStudioRebakeAllConfig : ScriptableObject {
    public string[] IncludePaths /* System.String[] */;
    public string[] ExcludePaths /* System.String[] */;
    public string[] IncludeOnlyCharacters /* System.String[] */;
    public string[] SkipCharacters /* System.String[] */;
    public bool RebakeOnlyBroken /* System.Boolean */;
    public string[] BrokenCharacters /* System.String[] */;
}

}

