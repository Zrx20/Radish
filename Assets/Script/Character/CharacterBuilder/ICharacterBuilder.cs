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
    //�趨��������
    public abstract void SetBuildParam(ICharacterBuildParam theParam);
    //����Asset�еĽ�ɫģ��
    public abstract void LoadAsset(int GameObjectID);
    //���������
    public abstract void AddCharacterSystem(PBaseDefenseGame PBDGame);
}
