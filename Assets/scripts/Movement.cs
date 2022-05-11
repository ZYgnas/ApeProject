using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public static float moveSpeed = 15f;

    public Rigidbody2D rb;

    Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    public void SpeedPlus()
    {
        if(scoreManager.money >= 50)
        {
            moveSpeed += .5f;
            scoreManager.money -= 50;
        }
    }

    public void SpeedMinus()
    {
        if(moveSpeed> 15f)
        {
            moveSpeed -= .5f;
            scoreManager.money += 10;
        }
    }
}