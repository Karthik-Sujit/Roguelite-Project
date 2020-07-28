using System.Collections;
using System.Collections.Generic;
using System.Threading;
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
        Dodge();
    }

    void Shoot()
    {
        if (Input.GetAxisRaw("Fire1") > 0)
        {
            print("BANG!");
        }
    }

    void Dodge()
    {
        if (Input.GetAxisRaw("Dodge") > 0)
        {
            print("WHOA! That was close!");
        }
    }

    void FixedUpdate()
    {
        playerRb.MovePosition(playerRb.position + moveVel.normalized * moveSpeed * Time.deltaTime);
    }
}
