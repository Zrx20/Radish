using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainUISystem : IGameSystem
{
    //uiµÄ°ó¶¨
    private Button m_aRangeBtn = null;
   public MainUISystem(PBaseDefenseGame PBDGame):base(PBDGame)
    {
        Initialize();
    }
    public override void Initialize()
    {

        m_aRangeBtn = GameObject.Find("Button").GetComponent<Button>();
        m_aRangeBtn.onClick.AddListener(() => OnaRange());
        MessageManager.Ins.OnAddListeen(1002, ShowUIButton);
    }
    public void ShowUIButton(object obj)
    {
        object[] arr = obj as object[];
        int a = (int)arr[0];

    }
    public void OnaRange()
    {
        MessageManager.Ins.OnDisPatch(1001);
    }
}
