using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frogman : MonoBehaviour
{
    private float jumpForce;
    private float moveSpeed;
    private bool enraged;
    private Rigidbody2D rigidbody;

    public Frogman(Rigidbody2D rb)
    {
        rigidbody = rb;
        enraged = false;
        moveSpeed = 5f;
        jumpForce = 7f;
    }

    public void changeVelocity()
    {
        Debug.Log("yee");
        rigidbody.velocity = new Vector2(Input.GetAxis("Horizontal") * moveSpeed, rigidbody.velocity.y);
    }

}
