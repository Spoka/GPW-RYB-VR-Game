using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneLoad : MonoBehaviour
{
	public GameObject BasePlatform;
	public GameObject TestLevel1;
    public ScoreScript score;
    public Text hScoreTxt;
    public HighScore highScore;

    public Animator pipesAnimator;

    //public GameObject RedPipe;
    //public GameObject YellowPipe;
    //public GameObject BluePipe;
    //public Transform redTransform;
    //public Transform yellowTransform;
    //public Transform blueTransform;


    // Start is called before the first frame update
    void Start()
    {
        //redTransform.position = RedPipe.transform.position;
        //redTransform.rotation = RedPipe.transform.rotation;
        //yellowTransform = YellowPipe.transform;
        //blueTransform = BluePipe.transform;

        //print(redTransform.position);
    }

	public void LoadScene()
	{
		BasePlatform.SetActive(false);
		TestLevel1.SetActive(true);
		
		score.score = 0;
		print(score.score);
        //print(redTransform.position);
    }

	public void UnloadScene()
	{
        pipesAnimator.SetBool("CicleBool", false);
        highScore.highScore = score.score;
		BasePlatform.SetActive(true);
		TestLevel1.SetActive(false);
        hScoreTxt.text = "Player 1: " + highScore.highScore.ToString();
	}

    //public void ResetPipesPosition()
    //{
    //    //not working
    //    RedPipe.gameObject.transform.position = redTransform.position;
    //    RedPipe.gameObject.transform.rotation = redTransform.rotation;
    //    YellowPipe.transform.position = yellowTransform.position;
    //    YellowPipe.transform.rotation = yellowTransform.rotation; 
    //    BluePipe.transform.position = blueTransform.position;
    //    BluePipe.transform.rotation = blueTransform.rotation;
    //    //not working
    //}
}
