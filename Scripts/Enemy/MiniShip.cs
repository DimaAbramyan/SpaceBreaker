using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UIElements;

public class MiniShip : Enemy
{
    private bool FlyingToPlayer = false;
    GameObject player;
    private Rigidbody2D rb;
    private float timer;
    private void Start()
    {
        rb = GetComponent <Rigidbody2D>();
        player = FindObjectOfType<FirstShip>().gameObject;
    }
    private void Update()
    {
       if (!FlyingToPlayer)
            return;
       timer -= Time.deltaTime;
        if (timer <= 0)
        MoveForvard();

    }
    public void Launch()
    {
        rb.velocity = Vector2.zero;
        rb.AddForce(new Vector2((transform.rotation.eulerAngles.z - 180)/(_speed/40), 0));
        transform.SetParent(null);
        //Debug.Log();
        FlyingToPlayer=true;
        timer = 2f;
    }
    protected void MoveForvard()
    {
        if (player == null) return;

        Vector2 direction = (player.transform.position - transform.position).normalized;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, angle+90);
        rb.AddForce(direction * _speed/25, ForceMode2D.Force);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        FirstShip receiver = collision.gameObject.GetComponentInChildren<FirstShip>();
        Debug.Log(receiver);
        if (receiver != null)
        {
            receiver.TakeDamage(_damage);
            Destroy(gameObject);
        }
    }
}
