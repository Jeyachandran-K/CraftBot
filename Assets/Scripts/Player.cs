using System;
using System.Buffers.Text;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
     public static Player Instance {  get; private set; }

    private Rigidbody playerRigidbody;
    
    [SerializeField]private float playerMovementSpeed;
    [SerializeField]private float playerRotateSpeed;

    public event EventHandler OnCubesHit;

    private void Awake()
    {
        Instance = this;
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
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out BasicCube basicCube))
        {
            OnCubesHit?.Invoke(this, EventArgs.Empty);
            basicCube.DestroySelf();
        }
    }
}
