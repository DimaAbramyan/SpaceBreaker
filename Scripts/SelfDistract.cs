using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDistract : MonoBehaviour
{
    float time;
    void Start()
    {
        time = 24f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        time -= Time.deltaTime;
        if (time < 0 )
            Destroy(gameObject);
    }
}
