using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MonoBehaviourScript : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] float jumpForce;
    //[SerializeField] ContactFilter2D groundLayer;
    [SerializeField] LayerMask Ground;

    private Rigidbody2D rb;
    private bool isGrounded;

    public Animator anim;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

    }
   
    void Update()
    {
        Move();
        Jump();
    }

    void Move()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector2 velocity = rb.velocity;
        velocity.x = horizontalInput * moveSpeed;
        rb.velocity = velocity;
        
        if (horizontalInput < 0)
            transform.localScale = new Vector2(-0.22f, 0.22f);
        else if (horizontalInput > 0)
            transform.localScale = new Vector2(0.22f, 0.22f);

        anim.SetFloat("moveX", Mathf.Abs(Input.GetAxisRaw("Horizontal")));
    }

    void Jump()
    {
        isGrounded = rb.IsTouchingLayers(Ground);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }
}
