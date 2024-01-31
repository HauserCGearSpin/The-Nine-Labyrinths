using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterExitHouse : MonoBehaviour
{
    [SerializeField] private GameObject ExteriorPoint;
    [SerializeField] private GameObject InteriorPoint;
    [SerializeField] private GameObject ButtonPrompt;
    [SerializeField] private GameObject Player;
    [SerializeField] private bool isExterior;

    private void Update()
    {
        if (ButtonPrompt.activeInHierarchy)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (isExterior)
                {
                    Player.transform.position = InteriorPoint.transform.position;
                }

                else if (!isExterior)
                {
                    Player.transform.position = ExteriorPoint.transform.position;
                }
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        ButtonPrompt.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        ButtonPrompt.SetActive(false);
    }
}
