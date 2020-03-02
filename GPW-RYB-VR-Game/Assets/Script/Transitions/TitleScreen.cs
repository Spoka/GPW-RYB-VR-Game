using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// GENERAL PURPOSE SCRIPT FOR SCENE TRANSITIONS.

public class TitleScreen : MonoBehaviour // SCRIPT NAME WILL BE AMENDED TO SOMETHING MORE SUITABLE IN DUE COURSE.
{
    public void GoTo_MainMenu() // Transition from title screen to main menu
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void GoTo_GameplayScene() // Transition from main menu to gameplay scene
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void GoTo_TitleScreen() // Transition from main menu to title screen
    {
        SceneManager.LoadScene("TitleScreen");
    }

    public void QuitGame() // Quit game application
    {
        UnityEditor.EditorApplication.isPlaying = false; // Used for quitting the application inside Unity Editor
        
        //Application.Quit(); // Use for actual build quit functionality!!!
    }
}
