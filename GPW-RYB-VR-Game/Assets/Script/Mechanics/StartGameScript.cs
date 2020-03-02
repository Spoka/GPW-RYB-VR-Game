using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGameScript : GameTimerScript
{
    //public GameObject newGameCanvas;
    public ScoreScript scoreScript;

    private void Start()
    {
        Time.timeScale = 0;
        gameOver = true;
        //newGameCanvas = gameObject;
    }

    public void StartGame()
    {
        gameOver = false;
        scoreScript.score = 0;
        gameLights.SetActive(true);
        Time.timeScale = 1;
        //gameObject.SetActive(false);
    }

    public void ButtonPressed()
    {
        print("button pressed!");
    }
}
