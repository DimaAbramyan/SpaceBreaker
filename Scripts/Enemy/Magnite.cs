using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magnite : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D rb;
    private void Start()
    {
        
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        //Debug.Log(collision.transform.position);
        rb.AddForce((collision.gameObject.transform.position - transform.position + new Vector3(0, 0.3f)).normalized * 10);
    }
    
}
