using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerController : MonoBehaviour
{
    //create private internal references
    private InputActions inputActions;
    private InputAction movement;
    public float jumpSpeed = 3.5f;
    
    Rigidbody rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>(); //get rigidbody, responsible for enabling collision with other colliders
    inputActions = new InputActions(); //create new InputActions
    }
    //called when script enabled
    private void OnEnable()
    {
        movement = inputActions.Player.Movement; //get reference to movement action
        movement.Enable();
        //create a DoJump callback function
        //DoJump automatically called when Jump binding performed
        inputActions.Player.Jump.performed += DoJump;
        inputActions.Player.Jump.Enable();
    }
//called when script disabled
private void OnDisable()
    {
        movement.Disable();
        inputActions.Player.Jump.Disable();
    }
    private void DoJump(InputAction.CallbackContext obj)
    {
        Vector2 v2 = movement.ReadValue<Vector2>();
        Vector3 v3 = new Vector3(v2.x, 0, v2.y);
        Debug.Log("Jump"); //called when jump performed
        rb.AddForce(Vector2.up * jumpSpeed, ForceMode.VelocityChange);
    }
    //called every physics update
    private void FixedUpdate()
    {
        Vector2 v2 = movement.ReadValue<Vector2>(); //extract 2d input data
        Vector3 v3 = new Vector3(v2.x, 0, v2.y); //convert to 3d space
        //transform.Translate(v3); //moves transform, ignoring physics
        rb.AddForce(-v3, ForceMode.VelocityChange); 
                                 //apply instantphysics force, ignoring mass
    }
}
