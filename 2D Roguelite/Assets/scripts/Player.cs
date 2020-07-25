using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D playerRb;
    Vector2 moveVel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Input
        moveVel.x = Input.GetAxisRaw("Horizontal");
        moveVel.y = Input.GetAxisRaw("Vertical");
        Shoot();
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
        playerRb.MovePosition(playerRb.position + moveVel * moveSpeed * Time.deltaTime);
    }
}
