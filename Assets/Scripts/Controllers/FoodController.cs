using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodController : MonoBehaviour
{
    private SpriteRenderer spriteR;
    private StatusController statusControllerHealth;
    private StatusController statusControllerScore;

    void Start()
    {
        spriteR = gameObject.GetComponent<SpriteRenderer>();
        spriteR.sprite = GameObject.Find("SpriteManager").GetComponent<SpriteManager>().randomSprite();
        statusControllerHealth = GameObject.Find("Health").GetComponent<StatusController>();
        statusControllerScore = GameObject.Find("Score").GetComponent<StatusController>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Water")
        {
            statusControllerHealth.reduceHealth();
        }

        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("EAT");
            
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Water")
        {
            Destroy(gameObject);
        }
    }

}
