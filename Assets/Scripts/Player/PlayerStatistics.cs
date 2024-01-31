using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatistics : MonoBehaviour, IDataPersistence
{
    [SerializeField] private float health;
    [SerializeField] private float speed;
    [SerializeField] private float coins;
    [SerializeField] private float arrows;
    [SerializeField] public float playerLevel;

    public void LoadData(GameData data)
    {
        this.arrows = data.arrowCount;
        this.playerLevel = data.playerLevel;
    }
    public void SaveData(ref GameData data) 
    {
        data.arrowCount = this.arrows;
        data.playerLevel = this.playerLevel;
    }
}
