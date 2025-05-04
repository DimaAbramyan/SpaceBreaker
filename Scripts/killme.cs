using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killme : MonoBehaviour
{
    [SerializeField] float TimeToLive;
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        TimeToLive -= Time.deltaTime;
        if (TimeToLive < 0 )
        {
            Destroy( this.gameObject );
        }
    }
}
