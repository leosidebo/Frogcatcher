using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteManager : MonoBehaviour
{
    public Sprite[] sprites;
       
    public Sprite randomSprite()
    {
        return sprites[Random.Range(0, 63)];
    }
}
