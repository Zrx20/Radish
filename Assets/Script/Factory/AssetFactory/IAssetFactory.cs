using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class IAssetFactory 
{
    public abstract GameObject LoadGameObject(string AssetName);
}
