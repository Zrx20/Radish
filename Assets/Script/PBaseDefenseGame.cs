using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PBaseDefenseGame
{
    private static PBaseDefenseGame _instance;
    public static PBaseDefenseGame Instance
    {
        get
        {
            if (_instance == null)
                _instance = new PBaseDefenseGame();
            return _instance;
        }
    }
    private CharacterSystem m_CharacterSystem = null;//角色管理系统
    private MapSystem m_MapSystem = null;//地图管理系统
    private MainUISystem m_MainUISystem = null;//主场景UI系统
    private ARangeSys m_ARangeSys = null;//随机系统
    private PBaseDefenseGame() { }
    public void Initinal()
    {
        m_CharacterSystem = new CharacterSystem(this);//角色管理系统
        m_MapSystem = new MapSystem(this);//地图管理系统
        m_ARangeSys = new ARangeSys(this);//随机系统
        m_MainUISystem = new MainUISystem(this);//主场景UI系统
        
        for (int i = 0; i < GameObject.Find("Map").transform.childCount; i++)
        {
            AddMapItem(GameObject.Find("Map").transform.GetChild(i));
        }
        ICharacterFactory Factory = PBDFactory.GetCharaterFactory();
        IGamePlayer thePlay = Factory.CreatPlayer(E_PlayerType.MySelf, Vector3.zero);
    }
    public void AddMapItem(Transform mapItem)
    {
        if (m_MapSystem!=null)
        {
            m_MapSystem.AddMapList(mapItem);
        }
    }
    public void AddSoldier(IGamePlayer theGamePlayer)
    {
        if (m_CharacterSystem != null)
            m_CharacterSystem.AddSoldier(theGamePlayer);
    }
}
