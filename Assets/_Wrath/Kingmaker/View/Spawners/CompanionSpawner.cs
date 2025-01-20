using System;
using UnityEngine;

namespace Kingmaker.View.Spawners {

public class CompanionSpawner {
    [SerializeField] public bool m_UsePet /* System.Boolean */;
    [SerializeField] public bool m_IsPlayerPet /* System.Boolean */;
    [SerializeField] public object m_PetType /* Kingmaker.Enums.PetType */;
    [SerializeField] public bool m_SpawnWhenRemote /* System.Boolean */;
    [SerializeField] public bool m_SpawnWhenInCapital /* System.Boolean */;
    [SerializeField] public bool m_SpawnWhenEx /* System.Boolean */;
    [SerializeField] public object ShowCondition /* Kingmaker.ElementsSystem.ConditionsReference */;
    [SerializeField] public bool m_Dummy /* System.Boolean */;

    public interface IResetHandler {
    }

}

}

