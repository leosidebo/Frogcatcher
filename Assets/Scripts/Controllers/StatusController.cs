using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusController : MonoBehaviour
{
    private int health;
    private int score;
    private Text text;
    void Start()
    {
        health = 3;
        score = 0;
        text = GetComponent<Text>();
    }

    public void reduceHealth()
    {
        health--;
        text.text = "Health: " + health.ToString();
        // Add a game over control here
    }

    public void increaseScore()
    {
        score = score + 5;
        text.text = "Score: " + score.ToString();
    }
}
