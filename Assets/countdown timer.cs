using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class countdowntimer : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 200f;
    bool gameEnded = false;

    [SerializeField] Text countdownText;
    Board board;
    void Start()
    {
        currentTime = startingTime;
        board = FindObjectOfType<Board>();
    }

    void Update () 
    {
        if (gameEnded) return;
        currentTime -= 1* Time.deltaTime;
        Debug.Log(currentTime);
        countdownText.text = currentTime.ToString("0");

        if (currentTime <= 0) 
        {
        currentTime = 0;
        board.GameOver();
        gameEnded = true;
        }
    }
}

