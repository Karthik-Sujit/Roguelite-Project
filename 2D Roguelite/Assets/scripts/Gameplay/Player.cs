using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D playerRb;
    public CircleCollider2D playerCollider;
    Vector2 moveDir;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Input params
        moveDir.x = Input.GetAxisRaw("Horizontal");
        moveDir.y = Input.GetAxisRaw("Vertical");
        // Player actions
        Shoot();
        Dodge();
    }

    void Dodge()
    {
        if (Input.GetAxisRaw("Dodge") > 0)
        {
            // If dodgeCooldown == 0, set I Frame counter and disable playerCollider

                // dash player

            print("Whoa! That was close!");
        }
    }

    void Shoot()
    {
        if (Input.GetAxisRaw("Fire1") > 0)
        {
            print("BANG!");
        }
    }

    void FixedUpdate()
    {
        playerRb.MovePosition(playerRb.position + moveDir * moveSpeed * Time.deltaTime);
        // decrement and check I Frame counter
    }
}
