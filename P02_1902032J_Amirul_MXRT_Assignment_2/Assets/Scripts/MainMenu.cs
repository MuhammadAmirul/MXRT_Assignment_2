using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // This method is applied in the Start_Button in Main_Menu Scene.
    // It will load the Gameplay_Scene once the button is pressed.
    public void StartGame()
    {
        SceneManager.LoadScene("Gameplay_Scene");
    }

    // This method is applied in the Exit_Button in Main_Menu Scene.
    // It will close this application.
    public void ExitGame()
    {
        Application.Quit();
    }
}
