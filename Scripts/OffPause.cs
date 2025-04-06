using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OffPause : MonoBehaviour
{
    public void GoToFight()
    {
        SceneManager.LoadScene("ImplimentPauseHere");
        Time.timeScale = 1;
    }
}
