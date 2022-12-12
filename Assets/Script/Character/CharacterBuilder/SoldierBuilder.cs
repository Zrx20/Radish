using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierBuildParam :ICharacterBuildParam
{
    public SoldierBuildParam()
    {

    }
}

public class SoldierBuilder : ICharacterBuilder
{
    private SoldierBuildParam m_BuildParam = null;

    public override void AddCharacterSystem(PBaseDefenseGame PBDGame)
    {
        PBDGame.AddSoldier(m_BuildParam.NewCharacter as IGamePlayer);
    }

    public override void LoadAsset(int GameObjectID)
    {
        IAssetFactory AssetFactory = PBDFactory.GetAssetFactory();
        GameObject PlayerGameObject = AssetFactory.LoadGameObject(m_BuildParam.NewCharacter.GetAssetName());
        PlayerGameObject.transform.position = m_BuildParam.SpawnPosition;
        PlayerGameObject.gameObject.name = string.Format(GameObjectID.ToString());
        m_BuildParam.NewCharacter.SetGameObject(PlayerGameObject);
    }

    public override void SetBuildParam(ICharacterBuildParam theParam)
    {
        m_BuildParam = theParam as SoldierBuildParam;
    }
}
