﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public int score;
    Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        scoreText = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
    }
}