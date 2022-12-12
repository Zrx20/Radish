using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ICharacter 
{
    protected string m_Name = "";
    protected GameObject m_GameObject = null;//显示的unity模型
    protected string m_AssetName = "";//模型名称
    public ICharacter() { }
    //设定unity模型
    public void SetGameObject(GameObject theGameObject)
    {
        m_GameObject = theGameObject;
    }
    //取得unity模型
    public GameObject GetGameObject()
    {
        return m_GameObject;
    }
    //释放
    public void Release()
    {
        if (m_GameObject != null)
            GameObject.Destroy(m_GameObject);
    }
    //取得Asset名称
    public string GetAssetName()
    {
        return m_AssetName;
    }
    public void MoveTo(Vector3 Position)
    {
        m_GameObject.transform.position = Position;
    }
}
