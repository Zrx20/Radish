using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : ISceneState
{
    public GameState(SceneStateController Controller) : base(Controller)
    {
        this.StateName = "StartState";
    }
    public override void StateBegin()
    {
        PBaseDefenseGame.Instance.Initinal();
    }
    public override void StateEnd()
    {
        base.StateEnd();
    }
    public override void StateUpdate()
    {
        base.StateUpdate();
    }
}
