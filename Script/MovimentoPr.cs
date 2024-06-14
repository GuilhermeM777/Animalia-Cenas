using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoPr : MonoBehaviour
{
    public float speed = 30f;
    public float jumpForce = 10f;

    private bool isJumping = false;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float moveX = 0f;
        if (Input.GetKey(KeyCode.D))
        {
            moveX = 1f;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            moveX = -1f;
        }

        Vector2 movement = new Vector2(moveX, 0f);

        rb.velocity = new Vector2(movement.x * speed, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.W) && !isJumping)
        {
            rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
            isJumping = true;
        }
        else if (Input.GetKeyDown(KeyCode.W) && !isJumping)
        {
            rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
            isJumping = true;
        }
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }
    }
}
