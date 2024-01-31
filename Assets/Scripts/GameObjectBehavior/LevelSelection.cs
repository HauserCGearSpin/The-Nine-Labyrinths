using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSelection : MonoBehaviour
{
    private PlayerStatistics playerStatistics;
    [Header("Buttons")]
    [SerializeField] private GameObject button1;
    [SerializeField] private GameObject button2;
    [SerializeField] private GameObject button3;
    [SerializeField] private GameObject button4;
    [SerializeField] private GameObject button5;
    [SerializeField] private GameObject button6;
    [SerializeField] private GameObject button7;
    [SerializeField] private GameObject button8;
    [SerializeField] private GameObject button9;
    [SerializeField] private GameObject button10;


    private void Start()
    {
        playerStatistics = FindObjectOfType<PlayerStatistics>();
    }

    private void Update()
    {
       
    }

    private void ActivateButtons()
    {
        switch (playerStatistics.playerLevel)
        {
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
            case 5:
                break;
            case 6:
                break;
            case 7:
                break;
            case 8:
                break;
            case 9:
                break;
            case 10:
                break;
        }
    }
}
