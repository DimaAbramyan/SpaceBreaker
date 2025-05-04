using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnableLevels : MonoBehaviour
{
    int lvl;
    [SerializeField] public List<Button> ButtonToEnable;
    void Start()
    {
        lvl = FindAnyObjectByType<PlayerLevel>().GetLvl();
        Debug.Log(lvl);
        Debug.Log("FFFFFFFFFFF");

        for (int i = 0; i <= lvl; i++)
        {
            ButtonToEnable[i].interactable = true;
        }
    }
}
