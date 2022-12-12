using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARangeSys : IGameSystem
{
    //���ϵͳ
    public ARangeSys(PBaseDefenseGame PBDGame) : base(PBDGame)
    {
        Initialize();
    }
    //��Ϣ������Ӧ���������
    public override void Initialize()
    {
        MessageManager.Ins.OnAddListeen(1001, RandomNumber);
    }
    public void RandomNumber(object obj)
    {
        int numRandom = Random.Range(1, 4);
        MessageManager.Ins.OnDisPatch(1002, numRandom);
    }
}
