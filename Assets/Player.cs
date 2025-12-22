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
}
