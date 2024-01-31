using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractPrompt : MonoBehaviour
{
    [SerializeField] private GameObject prompt;

    private void OnTriggerEnter(Collider other)
    {
        prompt.SetActive(true);
    }
    private void OnTriggerExit(Collider other)
    {
        prompt.SetActive(false);
    }
}
