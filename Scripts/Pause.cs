using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    [SerializeField]
    GameObject PauseTitle;
    public void PauseOn()
    {
        PauseTitle.SetActive(true);
        Time.timeScale = 0f;
    }
    public void PauseOff()
    {
        PauseTitle.SetActive(false);
        Time.timeScale = 1f;
    }
}
