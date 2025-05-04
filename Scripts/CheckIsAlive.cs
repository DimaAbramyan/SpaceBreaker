using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckIsAlive : MonoBehaviour
{
    Enemy check;
    void Start()
    {
       check = GetComponentInChildren<Enemy>();
    }
    
    void Update()
    {
        Debug.Log(check.isDead);
        if (check.isDead)  
        {
            Destroy(gameObject);
        }
    }
}
