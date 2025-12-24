using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public static Player Instance {  get; private set; }

    private Rigidbody playerRigidbody;
    
    [SerializeField]private float playerMovementSpeed;
    [SerializeField]private float playerRotateSpeed;

    public event EventHandler<OnCubeHitEventArgs> OnCubeHit;

    public class OnCubeHitEventArgs : EventArgs
    {
        public CubeSO cubeSO;
    }

    private void Awake()
    {
        Instance = this;
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
    private float playerheight = 2f;
    private float playerRadius = 0.5f;
    private float maxRayDistance = 2f;

    private void HandleInteraction()
    {
        if(Physics.CapsuleCast(transform.position,transform.position+transform.up*playerheight,playerRadius,transform.forward,out RaycastHit raycastHit,maxRayDistance))
        {
            if(raycastHit.collider.TryGetComponent(out BasicCube basicCube))
            {
                OnCubeHit?.Invoke(this, new OnCubeHitEventArgs
                {
                    cubeSO=basicCube.GetCubeSO(),
                });
                basicCube.DestroySelf();
            }
        }
    }
}
