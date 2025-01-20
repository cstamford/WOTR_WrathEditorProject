using System;
using UnityEngine;

namespace Rewired.Integration.UnityUI {

public class RewiredStandaloneInputModule {
    [SerializeField] public object rewiredInputManager /* Rewired.InputManager_Base */;
    [SerializeField] public bool useAllRewiredGamePlayers /* System.Boolean */;
    [SerializeField] public bool useRewiredSystemPlayer /* System.Boolean */;
    [SerializeField] public int[] rewiredPlayerIds /* System.Int32[] */;
    [SerializeField] public bool usePlayingPlayersOnly /* System.Boolean */;
    [SerializeField] public object playerMice /* System.Collections.Generic.List */;
    [SerializeField] public bool moveOneElementPerAxisPress /* System.Boolean */;
    [SerializeField] public bool setActionsById /* System.Boolean */;
    [SerializeField] public int horizontalActionId /* System.Int32 */;
    [SerializeField] public int verticalActionId /* System.Int32 */;
    [SerializeField] public int submitActionId /* System.Int32 */;
    [SerializeField] public int cancelActionId /* System.Int32 */;
    [SerializeField] public string m_HorizontalAxis /* System.String */;
    [SerializeField] public string m_VerticalAxis /* System.String */;
    [SerializeField] public string m_SubmitButton /* System.String */;
    [SerializeField] public string m_CancelButton /* System.String */;
    [SerializeField] public float m_InputActionsPerSecond /* System.Single */;
    [SerializeField] public float m_RepeatDelay /* System.Single */;
    [SerializeField] public bool m_allowMouseInput /* System.Boolean */;
    [SerializeField] public bool m_allowMouseInputIfTouchSupported /* System.Boolean */;
    [SerializeField] public bool m_allowTouchInput /* System.Boolean */;
    [SerializeField] public bool m_deselectIfBackgroundClicked /* System.Boolean */;
    [SerializeField] public bool m_deselectBeforeSelecting /* System.Boolean */;
    [SerializeField] public bool m_ForceModuleActive /* System.Boolean */;
}

}

