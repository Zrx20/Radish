using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartState : ISceneState
{
    //UIϵͳ
    public StartState(SceneStateController Controller):base(Controller)
    {
        this.StateName = "StartState";
    }
    public override void StateBegin()
    {
        base.StateBegin();
        Button btn = GameObject.Find("Button").GetComponent<Button>();
        if (btn != null)
            btn.onClick.AddListener(() =>
            {
                m_Controller.SetState(new GameState(m_Controller),"GameScene");
            });
    }
}
