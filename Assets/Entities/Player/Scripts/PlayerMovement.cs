using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public Transform groundCheck;
    public LayerMask groundLayer;

    public float speed = 5f;
    public float jumpSpeed = 10f;

    private float horizontal;
    private bool facingRight = true;

    public static bool inWater = false;

    public Animator animator;

    public GameObject camera;

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(isGrounded())
        {
            animator.SetBool("IsJumping", false);
        }
        else
        {
            animator.SetBool("IsJumping", true);
        }

        if(inWater && rb.drag == 0f) {
            rb.drag = 10f;
        }

        else if(!inWater && rb.drag == 10f) {
            rb.drag = 0f;
        }

        if(isGrounded() && Input.GetKey("w"))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);

        }

        else if(inWater && Input.GetKey("w")) {
            rb.velocity = new Vector2(rb.velocity.x, jumpSpeed/2);
        }

        horizontal = Input.GetAxisRaw("Horizontal");

        animator.SetFloat("Speed", Mathf.Abs(horizontal * speed));
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
        Flip();
    }

    void Flip()
    {
        Vector3 currScale = gameObject.transform.localScale;

        if (horizontal < 0 && facingRight)
        {
            currScale.x *= -1;
            facingRight = false;
        }
        else if(horizontal > 0 && !facingRight)
        {
            currScale.x *= -1;
            facingRight = true;
        }

        gameObject.transform.localScale = currScale;
    }

    public bool isGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Rock"))
        {
            camera.transform.position = new Vector3(0, 0, -10);
        }
    }
}
