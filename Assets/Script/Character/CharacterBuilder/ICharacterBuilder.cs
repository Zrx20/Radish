using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ICharacterBuildParam
{
    public E_PlayerType emPlayerType = E_PlayerType.Null;
    public ICharacter NewCharacter = null;
    public Vector3 SpawnPosition;
    public int AttrID;
    public string AssetName;
}
public abstract class ICharacterBuilder 
{
    //设定建立参数
    public abstract void SetBuildParam(ICharacterBuildParam theParam);
    //载入Asset中的角色模型
    public abstract void LoadAsset(int GameObjectID);
    //加入管理器
    public abstract void AddCharacterSystem(PBaseDefenseGame PBDGame);
}
