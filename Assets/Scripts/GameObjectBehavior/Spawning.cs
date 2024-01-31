using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour
{
    void Start()
    {
        int spawnValue;
        spawnValue = Random.Range(0, 5);

        if (spawnValue < 3)
            Destroy(this.gameObject);
    }
}
