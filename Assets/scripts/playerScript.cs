using System;
using System.Collections;
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

    private float moveSpeed;
    private Vector2 moveDirection;
    public float playerSpeed;
    public void playerMovement()
    {
         moveDirection = Vector2.right;
    }  

    private void FixedUpdate()
    {   
        myRigidBody2D.linearVelocity = moveDirection * playerSpeed;
    }
   
    public  IEnumerator StopMovement()
   {
    Debug.Log("Começou");
    yield return new WaitForSeconds(0.3f);
    Debug.Log("Terminou");

    moveDirection = Vector2.zero;
   }
}
