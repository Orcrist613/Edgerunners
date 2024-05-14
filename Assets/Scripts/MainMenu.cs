using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void Home()
    {
        SceneManager.LoadSceneAsync(0);
    }


    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(1);


    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
