using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadingLevels : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int currLevel = GetComponent<PlayerLevel>().GetLvl();
       // Debug.Log(currLevel);
    }

    
}
