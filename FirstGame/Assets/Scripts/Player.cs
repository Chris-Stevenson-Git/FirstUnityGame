using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float moveSpeed;
    public Rigidbody2D rig;
    public float jumpForce;

    void FixedUpdate () 
    {
        float xInput = Input.GetAxis("Horizontal");

        rig.velocity = new Vector2(xInput * moveSpeed, rig.velocity.y);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            rig.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    } // Update
}
