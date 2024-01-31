using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData
{
    public float arrowCount;
    public float playerLevel;

    // values defined in constructor will be default values
    // game starts with these default values when there's no data to load
    public GameData()
    {
        this.arrowCount = 0;
        this.playerLevel = 1;
    }
}
