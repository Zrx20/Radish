using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBuilderSystem : IGameSystem
{
    protected int m_GameObjectID = 0;
    public CharacterBuilderSystem(PBaseDefenseGame PBDGame) : base(PBDGame)
    { 
    }
    public override void Initialize()
    {
       
    }
    public override void Update()
    {
       
    }
    public void Construct(ICharacterBuilder theBuilder)
    {
        theBuilder.LoadAsset(++m_GameObjectID);
    }
}
