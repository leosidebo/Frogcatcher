using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetSize : MonoBehaviour
{
    private SpriteRenderer renderer;
    private Vector3 size;
    private static float x;
    private static float y;


    private void Awake()
    {
        renderer = GetComponent<SpriteRenderer>();
        size = renderer.bounds.size;
        x = size.x;
        y = size.y;
    }

    public static float getX()
    {
        return x;
    }

    public static float getY()
    {
        return y;
    }
}
