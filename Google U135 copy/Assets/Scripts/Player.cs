using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;

    private Vector2 movement;

    int speed;

    private void Start()
    {
        speed = 20;
        rb = GetComponent<Rigidbody2D>();
        movement = GetComponent<Vector2>();
    }

    private void Update()
    {

        if (Input.GetKey(KeyCode.D))
        {
            movement.x = speed;
            movement.y = 0;
        }
        if (Input.GetKey(KeyCode.A))
        {
            movement.x = -speed;
            movement.y = 0;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            movement.x = 0;
            movement.y = 50;
        }
    }

    void FixedUpdate()
    {
        MoveCharacter();
        movement.x = 0;
        movement.y = 0;

    }

    void MoveCharacter()
    {
        rb.MovePosition(rb.position + movement * Time.deltaTime);
    }

}
