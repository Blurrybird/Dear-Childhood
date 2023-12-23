using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playermovement : MonoBehaviour {
    
    [SerializeField] private float speed = 5f;

    private Vector2 movement;
    private Rigidbody2D rb;
    private Animator animator;

    private void Awake() {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }


    private void OnMovement (InputValue value) {
        movement = value.Get<Vector2>();

        if (movement.x != 0) {
             animator.SetFloat("MoveX", movement.x);
             
             animator.SetBool("isWalking", true);
        } else {
            animator.SetBool("isWalking", false);
        }
    }

    private void FixedUpdate() {
        // Variant 1
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);

        // Variant 2
        // if (movement.x != 0) 
        // {
        //    rb.velocity = movement * speed; 
        // } 

        // Variant 3
        rb.AddForce(movement * speed);
    }
}
