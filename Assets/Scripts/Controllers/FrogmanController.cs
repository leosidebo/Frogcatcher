using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogmanController : MonoBehaviour
{
    public Frogman frogman;
    public Animator animator;
    private float horizontal;

    void Start()
    {
        // frogman = new Frogman(GetComponent<Rigidbody2D>());   

    }

    void FixedUpdate()
    {
        horizontal = Input.GetAxis("Horizontal");
        if (horizontal > 0 && !frogman.getFacingRight() || horizontal < 0 && frogman.getFacingRight())
        {
            frogman.flip();
        }

        frogman.changeVelocity();
        frogman.animateMovement(animator);
    }

}
