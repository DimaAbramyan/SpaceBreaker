using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MoveForvard : MonoBehaviour
{
    [SerializeField] private float speed = 0.01f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        this.transform.position += new Vector3(0,-speed);
        
    }
}
