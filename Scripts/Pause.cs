using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public void SetPauseAndGoToMenu()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("PauseMenu");
    }

}
