using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapSystem : IGameSystem
{
    private List<Transform> m_mapList = new List<Transform>();
    public MapSystem(PBaseDefenseGame PBDGame):base(PBDGame)
    {
        Initialize();
    }
    public void AddMapList(Transform mapItem)
    {
        if (mapItem!= null)
        {
            m_mapList.Add(mapItem);
        }
    }
}
