using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PBDFactory 
{
    private static bool m_bLoadFromResource = true;
    private static IAssetFactory m_AssetFactory = null;
    private static ICharacterFactory m_CharacterFactory = null;
    public static IAssetFactory GetAssetFactory()
    {
        if (m_AssetFactory == null)
        {
            if (m_bLoadFromResource)
                m_AssetFactory = new ResourceAssetProxyFactory();
            else
                m_AssetFactory = null;
        }
        return m_AssetFactory;
    }
    public static ICharacterFactory GetCharaterFactory()
    {
        if (m_CharacterFactory == null)
            m_CharacterFactory = new CharacterFactory();
        return m_CharacterFactory;
    }
}
