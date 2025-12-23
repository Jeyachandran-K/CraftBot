using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public static Player Instance {  get; private set; }

    private Rigidbody playerRigidbody;
    
    [SerializeField]private float playerMovementSpeed;
    [SerializeField]private float playerRotateSpeed;

    private InteractButtonUI interactButtonUI;

    public event EventHandler OnEKeyPressed;
    private void Awake()
    {
        Instance = this;

        playerRigidbody = GetComponent<Rigidbody>();
        interactButtonUI = GetComponentInChildren<InteractButtonUI>();
    }
    private void FixedUpdate()
    {
        HandleMovement();
        HandleInteraction();
    }
    private void HandleMovement()
    {
        if (Keyboard.current.wKey.isPressed)
        {
            playerRigidbody.AddForce(transform.forward * playerMovementSpeed);
        }
        if (Keyboard.current.sKey.isPressed)
        {
            playerRigidbody.AddForce(-transform.forward * playerMovementSpeed);
        }
        if (Keyboard.current.dKey.isPressed)
        {
            playerRigidbody.AddTorque(playerRotateSpeed*Vector3.up);
        }
        if (Keyboard.current.aKey.isPressed)
        {
            playerRigidbody.AddTorque(-playerRotateSpeed * Vector3.up);
        }
        if (Keyboard.current.eKey.isPressed)
        {
            OnEKeyPressed?.Invoke(this, EventArgs.Empty);
        }

    }

    private float playerHeight = 2f;
    private float playerRadius = 0.5f;
    private float maxRayDistance = 10f;
    
    private void HandleInteraction()
    {
        if (Physics.CapsuleCast(transform.position,transform.position+transform.up*playerHeight,playerRadius,transform.forward,out RaycastHit raycastHit,maxRayDistance))
        {
            Debug.Log("We Hit :" + raycastHit.collider);
            Debug.Log(!InteractButtonUI.Instance.GetHasClicked());
            if ( !InteractButtonUI.Instance.GetHasClicked())
            {
                interactButtonUI.Show();
            }
            
        }
        else
        {
            interactButtonUI.Hide();
        }
    }

}
