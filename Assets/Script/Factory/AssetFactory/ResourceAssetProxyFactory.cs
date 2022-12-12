using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceAssetProxyFactory : IAssetFactory
{
    private Dictionary<string, Object> m_GameObject = null;
    public ResourceAssetProxyFactory()
    {
        m_GameObject = new Dictionary<string, Object>();
    }
    public override GameObject LoadGameObject(string AssetName)
    {
        Object res = Resources.Load(AssetName);
        if (m_GameObject.ContainsKey(AssetName) == false)
        {
            m_GameObject.Add(AssetName, res);
        }
        return Object.Instantiate(res) as GameObject;
    }
}
