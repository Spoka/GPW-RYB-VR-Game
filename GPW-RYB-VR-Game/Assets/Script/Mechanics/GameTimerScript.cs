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
    //public GameObject newGameCanvas;
    public GameObject gameLights;

    protected bool gameOver;
    public bool GameOver { get { return gameOver; } }

	public SceneLoad sceneLoader;

    public Animator pipesAnimator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        gameTimer -= Time.deltaTime;
        gameTimerText.text = "Time Left: " + GameTimer.ToString();

        if (GameTimer <= 100)
        {
            pipesAnimator.SetBool("CicleBool", true);
            pipesAnimator.SetFloat("CicleSpeed", .3f);
        }

        if (GameTimer <= 60)
            pipesAnimator.SetFloat("CicleSpeed", .6f);

        if (GameTimer <= 20)
            pipesAnimator.SetFloat("CicleSpeed", .9f);

        if (GameTimer <= 1)
        {
            pipesAnimator.SetBool("CicleBool", false);
            pipesAnimator.SetTrigger("PosReset");
        }

        if (GameTimer <= 0)
        {
			//Time.timeScale = 0;
			//newGameCanvas.SetActive(true);
			//gameLights.SetActive(false);
			//gameOver = true;
			sceneLoader.UnloadScene();
            gameTimer = 120;
        }
    }
}
