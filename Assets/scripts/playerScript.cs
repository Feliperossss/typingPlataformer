using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    

    [SerializeField]
    private Rigidbody2D myRigidBody2D;

    Vector2 direction;
    public void Move(InputAction.CallbackContext context)
    {
         direction = context.ReadValue<Vector2>();
    }

    public void Update()
    {
        playerMovement();
    }

    public float playerSpeed;
    private void playerMovement()
    {

    }  

   
}
