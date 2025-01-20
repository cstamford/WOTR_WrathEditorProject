using Kingmaker.UI.MVVM._ConsoleView.Dungeon;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Kingmaker.UI.MVVM._PCView.Dungeon {

public class DungeonGameOverBaseView {
    [SerializeField] public global::System.Collections.Generic.List<global::UnityEngine.CanvasGroup> m_HideCanvasList /* System.Collections.Generic.List<UnityEngine.CanvasGroup> */;
    [SerializeField] public object m_HeaderText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.UI.Image m_MainBackgroundImage /* UnityEngine.UI.Image */;
    [SerializeField] public global::UnityEngine.Sprite m_DefeatSprite /* UnityEngine.Sprite */;
    [SerializeField] public global::UnityEngine.Sprite m_VictorySprite /* UnityEngine.Sprite */;
    [SerializeField] public global::UnityEngine.Sprite m_EndTierSprite /* UnityEngine.Sprite */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Dungeon.EntityTextValue m_AttemptEntity /* Kingmaker.UI.MVVM._ConsoleView.Dungeon.EntityTextValue */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Dungeon.EntityTextValue m_IslandEntity /* Kingmaker.UI.MVVM._ConsoleView.Dungeon.EntityTextValue */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Dungeon.EntityTextValue m_UnsurpassedOpponentEntity /* Kingmaker.UI.MVVM._ConsoleView.Dungeon.EntityTextValue */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Dungeon.EntityTextValue m_DurationGameEntity /* Kingmaker.UI.MVVM._ConsoleView.Dungeon.EntityTextValue */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Dungeon.EntityTextValue m_EnemiesDefeatedEntity /* Kingmaker.UI.MVVM._ConsoleView.Dungeon.EntityTextValue */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Dungeon.EntityTextValue m_BestFighterEntity /* Kingmaker.UI.MVVM._ConsoleView.Dungeon.EntityTextValue */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Dungeon.EntityTextValue m_ChestsFoundEntity /* Kingmaker.UI.MVVM._ConsoleView.Dungeon.EntityTextValue */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Dungeon.EntityTextValue m_ChestsTotalEntity /* Kingmaker.UI.MVVM._ConsoleView.Dungeon.EntityTextValue */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Dungeon.EntityTextValue m_CostEquipmentEntity /* Kingmaker.UI.MVVM._ConsoleView.Dungeon.EntityTextValue */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Dungeon.EntityTextValue m_DamageReceivedEntity /* Kingmaker.UI.MVVM._ConsoleView.Dungeon.EntityTextValue */;
    [SerializeField] public global::Kingmaker.UI.MVVM._ConsoleView.Dungeon.EntityTextValue m_DamageDoneEntity /* Kingmaker.UI.MVVM._ConsoleView.Dungeon.EntityTextValue */;
    [SerializeField] public global::UnityEngine.GameObject BoonGroup /* UnityEngine.GameObject */;
    [SerializeField] public global::UnityEngine.GameObject NoBoonGroup /* UnityEngine.GameObject */;
    [SerializeField] public object m_NoBoonItemText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public global::UnityEngine.UI.Image m_BoonItemImage /* UnityEngine.UI.Image */;
    [SerializeField] public object m_BoonItemText /* TMPro.TextMeshProUGUI */;
    [SerializeField] public object m_NextAttemptButtonText /* TMPro.TextMeshProUGUI */;
}

}

