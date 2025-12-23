using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private Rigidbody playerRigidbody;
    
    [SerializeField]private float playerMovementSpeed;
    [SerializeField]private float playerRotateSpeed;

    private void Awake()
    {
        playerRigidbody = GetComponent<Rigidbody>();
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

    }

    private float playerHeight = 2f;
    private float playerRadius = 0.5f;
    private float maxRayDistance = 10f;
    private void HandleInteraction()
    {
        if (Physics.CapsuleCast(transform.position,transform.position+transform.up*playerHeight,playerRadius,transform.forward,maxRayDistance))
        {
            Debug.Log("We Hit Something");
        }
    }

}
