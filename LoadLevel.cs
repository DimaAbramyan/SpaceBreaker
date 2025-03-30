using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{
    [SerializeField]
    private int m_Level = 0;
    public void LoadScene()
    {
        GameObject NotToDestroy = FindObjectOfType<AllSaves>().gameObject;
        DontDestroyOnLoad(NotToDestroy);
        SceneManager.LoadScene(m_Level);
    }
}
