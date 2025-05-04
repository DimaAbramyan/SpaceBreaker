using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLevel: MonoBehaviour
{
    private static PlayerLevel instance;
    public static int level = 0;
    public List<bool>  levelList;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void LvlUp()
    {
        if (levelList[SceneManager.GetActiveScene().buildIndex - 5] == false) 
            {
            levelList[SceneManager.GetActiveScene().buildIndex - 5] = true;
            level++;
        }
    }
    public int GetLvl()
    {
        return level;
    }
}
