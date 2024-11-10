using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public void NewGame()
    {
        SceneManager.LoadScene(0);
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene(1);
    }

    public void Settings()
    {
        SceneManager.LoadScene(2);
    }

    public void Exit()
    {
        Debug.Log("Выход из игры...");
        Application.Quit();
    }
}
