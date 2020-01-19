using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawner : MonoBehaviour
{
    private BoxCollider2D collider;
    private Vector3 size;
    private float width;
    private float startPoint;
    public GameObject food;

    void Start()
    {
        determineWidth();
        startPoint = 0 - (GetSize.getX() / 2);
        InvokeRepeating("spawnFood", 2.0f, 1.0f);
    }

    public void spawnFood()
    {
        Instantiate(food, new Vector3(randomizeSpawn(), transform.position.y, 0), Quaternion.identity);
    }

    public float randomizeSpawn()
    {
        return (startPoint + Random.Range(0f, width));
    }

    public void determineWidth()
    {
        collider = GetComponent<BoxCollider2D>();
        size = collider.bounds.size;
        width = size.x;
    }
}
