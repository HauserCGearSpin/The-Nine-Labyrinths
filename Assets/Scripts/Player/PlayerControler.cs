using System;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    // Invisible variables
    private Vector3 PlayerMovementInput;
    private Vector3 PlayerMouseInput;
    private float xRot;

    // Visible Variables
    [Header("Assignable Game Objects")]
    [SerializeField] private Rigidbody rb;
    [SerializeField] private Transform PlayerCamera;
    [SerializeField] private Transform FeetTransform;

    [Header("Layer Masks")]
    [SerializeField] private LayerMask FloorMask;

    [Header("Modifiable Floats")]
    [SerializeField] private float Speed;
    [SerializeField] private float Sensitivity;
    [SerializeField] private float Jumpforce;
    [SerializeField] private float cameraRotateXMin;
    [SerializeField] private float cameraRotateXMax;

    [Header("Modifiable Vectors")]
    [SerializeField] private Vector3 defaultPlayerPosition;

    [Header("Modifiable Bools")]
    [SerializeField] public bool characterIsActive;

    void Update()

    {
        if (characterIsActive)
        {
            GetInput();
            MovePlayer();
            MovePlayerCamrea();
            MouseLock();
            BoundsCheck();
            //Sprint();
        }
        
    }

    private void GetInput()
    {
            PlayerMovementInput = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
            PlayerMouseInput = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
    }

    private void MovePlayer()

    {
            Vector3 MoveVector = transform.TransformDirection(PlayerMovementInput) * Speed;
            rb.velocity = new Vector3(MoveVector.x, rb.velocity.y, MoveVector.z);

            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (Physics.CheckSphere(FeetTransform.position, 0.1f, FloorMask))
                {

                    rb.AddForce(Vector3.up * Jumpforce, ForceMode.Impulse);

                }
            }
    }

    private void MovePlayerCamrea()
    {
            xRot -= PlayerMouseInput.y * Sensitivity;
            xRot = Mathf.Clamp(xRot, cameraRotateXMin, cameraRotateXMax);

            transform.Rotate(0f, PlayerMouseInput.x * Sensitivity, 0f);
            PlayerCamera.transform.localRotation = Quaternion.Euler(xRot, 0f, 0f);
    }

    private void MouseLock()
    {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
    }

    private void Sprint()
    {
        if (Input.GetKey(KeyCode.LeftControl))
        {
            Speed = 7f;
        }

        else
        {
            Speed = 5f;
        }

    }

    private void BoundsCheck()
    {
        if (transform.position.y < -20f)
        {
            transform.position = defaultPlayerPosition;
            throw new Exception("Player Fell Out Of Bounds");
        }
    }
}