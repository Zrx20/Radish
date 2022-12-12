using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterFactory : ICharacterFactory
{
    private CharacterBuilderSystem m_BuilderDirector = new CharacterBuilderSystem(PBaseDefenseGame.Instance);

    public override IGamePlayer CreatPlayer(E_PlayerType emPlayer, Vector3 SpawnPosition)
    {
        SoldierBuildParam SoldierParam = new SoldierBuildParam();
        switch (emPlayer)
        {
            case E_PlayerType.MySelf:
                SoldierParam.NewCharacter = new MySelf();
                break;
            case E_PlayerType.Other:
                SoldierParam.NewCharacter = new Other();
                break;
        }
        if (SoldierParam.NewCharacter == null)
            return null;
        SoldierParam.SpawnPosition = SpawnPosition;

        SoldierBuilder theSoldierBuilder = new SoldierBuilder();
        theSoldierBuilder.SetBuildParam(SoldierParam);

        m_BuilderDirector.Construct(theSoldierBuilder);
        return SoldierParam.NewCharacter as IGamePlayer;
    }

}
