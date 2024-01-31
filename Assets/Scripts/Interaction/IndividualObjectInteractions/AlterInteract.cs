using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlterlInteract : MonoBehaviour, IInteractable
{
    [SerializeField] private GameObject alterCanvas;
    [SerializeField] private PlayerControler player;

    public void Interact()
    {
        if (Input.GetKey(KeyCode.E))
        {
            alterCanvas.SetActive(true);
            player.characterIsActive = false;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }

    public void OnCanvasClose()
    {
        player.characterIsActive = true;
    }
}
