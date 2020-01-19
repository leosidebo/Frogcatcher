using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogmanController : MonoBehaviour
{
    private Frogman frogman;
    void Start()
    {
        frogman = new Frogman(GetComponent<Rigidbody2D>());   
    }

    void FixedUpdate()
    {
        frogman.changeVelocity();
    }
}
