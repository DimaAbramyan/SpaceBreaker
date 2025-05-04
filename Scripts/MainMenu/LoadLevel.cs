using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{

    [SerializeField]
    private bool IsNextLevel;
    [SerializeField]
    private bool IsThatRepat;
    [SerializeField]
    private int m_Level = 0;
    public void LoadScene()
    {
        GameObject NotToDestroy = FindObjectOfType<AllSaves>().gameObject;
        DontDestroyOnLoad(NotToDestroy);
        if (IsThatRepat)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            return;
        }
        if (IsNextLevel)
        {
            Debug.Log("Нажал");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
            return;
        }
        SceneManager.LoadScene(m_Level);
    }
}
