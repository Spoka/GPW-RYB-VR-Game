using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public int highScore;
    public int score;
    public Text scoreText;    

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Your Score: " + score.ToString(); //Score UI updated
        if (PlayerPrefs.GetInt("Score") >= highScore)
            PlayerPrefs.SetInt("Score", highScore);       
    }
}
