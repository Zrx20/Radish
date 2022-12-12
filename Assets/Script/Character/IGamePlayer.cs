using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum E_PlayerType
{
    Null=0,
    MySelf = 1,
    Other =2
}
public abstract class IGamePlayer : ICharacter
{
    protected E_PlayerType m_emPlayerType = E_PlayerType.Null;
    public IGamePlayer() { }

    public E_PlayerType GetEnemyType()
    {
        return m_emPlayerType;
    }
}
