using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuffLevel : MonoBehaviour
{
    private FirstShip ship;
    private Vector3 f;
    private CircleCollider2D circleCollider;
    public GameObject Buff;
    private void Start()
    {
        //Buff = GetComponentInParent<GameObject>();
        circleCollider = GetComponentInChildren<CircleCollider2D>();
    }
    private void Update()
    {
        Buff.transform.localPosition += new Vector3(0, -1, 0) * 3.5f * Time.deltaTime;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GetComponent<Collider2D>().enabled = false;
        gameObject.SetActive(false);
        ship = collision.GetComponent<FirstShip>();
        if (ship.ship_Data._currentLvl < 4)
        ship.ship_Data._currentLvl++;
        Debug.Log(ship.ship_Data._currentLvl);
        Destroy(gameObject);
        Destroy(Buff);
    }
}
