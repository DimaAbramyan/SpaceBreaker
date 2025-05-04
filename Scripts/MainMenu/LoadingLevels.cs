using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadingLevels : MonoBehaviour
{
    EnableLevels lvls;
    void Start()
    {
        int currLevel = GetComponent<PlayerLevel>().GetLvl();
        lvls = FindAnyObjectByType<EnableLevels>();
        for (int i = 0; i < currLevel; i++)
        {
            Debug.Log(i);
            lvls.ButtonToEnable[i].enabled = true;
        }
    }

    
}
