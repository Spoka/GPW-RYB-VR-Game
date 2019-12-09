using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimerScript : MonoBehaviour
{
    [SerializeField]
    protected float gameTimer;
    public int GameTimer { get { return Mathf.RoundToInt(gameTimer); } }

    public Text gameTimerText;

    protected bool gameOver;
    public bool GameOver { get { return gameOver; } }

    // Start is called before the first frame update
    void Start()
    {
        gameTimer = 180.0f;
    }

    // Update is called once per frame
    void Update()
    {
        gameTimer -= Time.deltaTime;

        gameTimerText.text = "Time Left: " + GameTimer.ToString();

        if (GameTimer <= 0)
            gameOver = true;
    }
}
