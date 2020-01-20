using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frogman : MonoBehaviour
{
    private float jumpForce;
    private float moveSpeed;
    private bool enraged;
    private bool facingRight;
    private Rigidbody2D rigidbody;

    public Frogman(Rigidbody2D rb)
    {
        rigidbody = rb;
        enraged = false;
        moveSpeed = 5f;
        jumpForce = 7f;
        facingRight = false;
    }

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        enraged = false;
        moveSpeed = 5f;
        jumpForce = 7f;
        facingRight = false;
    }

    public void changeVelocity()
    {
        rigidbody.velocity = new Vector2(Input.GetAxis("Horizontal") * moveSpeed, rigidbody.velocity.y);
    }

    public void animateMovement(Animator animator)
    {
        animator.SetFloat("Speed", Mathf.Abs(Input.GetAxis("Horizontal") * moveSpeed));
    }

    public void flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

    public bool getFacingRight()
    {
        return facingRight;
    }

}
