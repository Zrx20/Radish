using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ICharacter 
{
    protected string m_Name = "";
    protected GameObject m_GameObject = null;//��ʾ��unityģ��
    protected string m_AssetName = "";//ģ������
    public ICharacter() { }
    //�趨unityģ��
    public void SetGameObject(GameObject theGameObject)
    {
        m_GameObject = theGameObject;
    }
    //ȡ��unityģ��
    public GameObject GetGameObject()
    {
        return m_GameObject;
    }
    //�ͷ�
    public void Release()
    {
        if (m_GameObject != null)
            GameObject.Destroy(m_GameObject);
    }
    //ȡ��Asset����
    public string GetAssetName()
    {
        return m_AssetName;
    }
    public void MoveTo(Vector3 Position)
    {
        m_GameObject.transform.position = Position;
    }
}
