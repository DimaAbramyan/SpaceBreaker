using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave1_1 : MonoBehaviour
{
    // Start is called before the first frame update
    int Lenght = 0;
    // Update is called once per frame
    void Update()
    {
        Lenght = GetComponentsInChildren<Enemy>().Length;
        if (Lenght == 0)
        {
            
        }
    }
}
