using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARangeSys : IGameSystem
{
    //随机系统
    public ARangeSys(PBaseDefenseGame PBDGame) : base(PBDGame)
    {
        Initialize();
    }
    //消息中心相应按键的随机
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
