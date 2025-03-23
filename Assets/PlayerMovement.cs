using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement")]
    public float walkSpeed;
    public float groundDrag;

    [Header("Ground Check")]
    public float playerHeight;
    public LayerMask IsGround;
    bool grounded;

    public Transform orientation;

    float horizontalInput;
    float verticalInput;

    Vector3 moveDirection;

    Rigidbody rb;

    void Start(){
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    void Update(){
        grounded = Physics.Raycast(transform.position, Vector3.down, playerHeight * 0.5f + 0.2f, IsGround); // Cast a ray to check if the player is touching ground

        TakeInput();
        LimitSpeed();

        // Apply drag when on ground
        if(grounded) 
            rb.drag = groundDrag;
        else 
            rb.drag = 0;
    }

    void FixedUpdate(){
        MovePlayer();
    }

    private void TakeInput(){
        // Get keyboard input using unity input manager
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
    }

    private void MovePlayer(){
        moveDirection = orientation.forward * verticalInput + orientation.right * horizontalInput; // Direction to add force towards
        rb.AddForce(moveDirection.normalized * walkSpeed * 10f, ForceMode.Force); // Adds Force
    }

    private void LimitSpeed(){
        // Calculate players 2D velocity
        Vector3 flatVel = new Vector3(rb.velocity.x, 0f, rb.velocity.z);

        // Limit players velocity if it exceeds the speed limit
        if(flatVel.magnitude > walkSpeed){
            Vector3 limitedVel = flatVel.normalized * walkSpeed;
            rb.velocity = new Vector3(limitedVel.x, rb.velocity.y, limitedVel.z);
        }
    }
}