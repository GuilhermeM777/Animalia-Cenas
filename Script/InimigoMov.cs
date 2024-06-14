using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InimigoMov : MonoBehaviour
{
    public float speed = 50f;

    private Rigidbody2D rb;
    private bool isMovingY = true;
    private bool isMovingX = false;
    private bool isMovingNegativeY = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (isMovingY)
        {
            rb.velocity = new Vector2(40f, speed);
            Invoke("MoveInX", 5f);
            isMovingY = false;
        }
        else if (isMovingX)
        {
            rb.velocity = new Vector2(speed, 20f);
            Invoke("MoveInNegativeX", 5f);
            isMovingX = false;
        }
        else if (isMovingNegativeY)
        {
            rb.velocity = new Vector2(2f, -speed);
        }
    }

    void MoveInX()
    {
        isMovingX = true;
    }

    void MoveInNegativeX()
    {
        rb.velocity = new Vector2(-speed, 20f);
        Invoke("MoveInNegativeY", 5f);
    }

    void MoveInNegativeY()
    {
        isMovingNegativeY = true;
    }
}