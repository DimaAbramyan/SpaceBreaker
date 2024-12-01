using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuffLevel : MonoBehaviour
{
    private Ship ship;
    private Vector3 f;
    private void Update()
    {
        transform.position += new Vector3(0, -1, 0) * 3.5f * Time.deltaTime;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        ship = collision.GetComponent<Ship>();
        if (ship._currentLvl < 4)
        ship._currentLvl++;
        Destroy(gameObject);
    }
}
