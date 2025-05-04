using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float constRotate;
    
    void FixedUpdate()
    {
        transform.Rotate(new Vector3(0, 0, constRotate));  
    }
}
