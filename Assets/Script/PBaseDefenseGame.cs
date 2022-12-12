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
    private CharacterSystem m_CharacterSystem = null;//��ɫ����ϵͳ
    private MapSystem m_MapSystem = null;//��ͼ����ϵͳ
    private MainUISystem m_MainUISystem = null;//������UIϵͳ
    private ARangeSys m_ARangeSys = null;//���ϵͳ
    private PBaseDefenseGame() { }
    public void Initinal()
    {
        m_CharacterSystem = new CharacterSystem(this);//��ɫ����ϵͳ
        m_MapSystem = new MapSystem(this);//��ͼ����ϵͳ
        m_ARangeSys = new ARangeSys(this);//���ϵͳ
        m_MainUISystem = new MainUISystem(this);//������UIϵͳ
        
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
