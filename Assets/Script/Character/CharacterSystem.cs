using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSystem : IGameSystem
{
    private List<ICharacter> m_Soldiers = new List<ICharacter>();
    private List<ICharacter> m_Enemys = new List<ICharacter>();
    public CharacterSystem(PBaseDefenseGame PBDGame):base(PBDGame)
    {
        Initialize();
    }
    public void AddSoldier(IGamePlayer player)
    {
        m_Soldiers.Add(player);
    }
    public void RemoveSoldier(IGamePlayer theGamePlayer)
    {
        m_Soldiers.Remove(theGamePlayer);
    }
}
