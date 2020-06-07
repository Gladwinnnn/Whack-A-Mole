using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public void LoadGameScene()
    {
        SceneManager.LoadScene("Game Scene");
    }

    public void LoadOptionMenu()
    {
        SceneManager.LoadScene("Option Menu");
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("Start Menu");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
