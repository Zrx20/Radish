using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ICharacterFactory 
{
    //建立人物
    public abstract IGamePlayer CreatPlayer(E_PlayerType emPlayer,Vector3 SpawnPosition);
}
