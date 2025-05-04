using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuffLevel : MonoBehaviour
{
    private bool _pickedUp = false;
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
        if (collision.GetComponent<FirstShip>() == null)
            return;
            if (_pickedUp) return;
            _pickedUp = true;
            GetComponent<Collider2D>().enabled = false;
            gameObject.SetActive(false);
            ship = collision.GetComponent<FirstShip>();
            ship.LvlUp();
            Debug.Log(ship.ship_Data._currentLvl);
            Physics2D.IgnoreCollision(collision, GetComponent<Collider2D>());
            PointsCollector.Bonuses += 1;
            Destroy(gameObject);
            Destroy(Buff);
        
    }
}
