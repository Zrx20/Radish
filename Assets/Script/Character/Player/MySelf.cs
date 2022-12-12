using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MySelf : IGamePlayer
{
    public MySelf()
    {
        m_emPlayerType = E_PlayerType.MySelf;
        m_AssetName = "1";
       
    }
}
