using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemyTurretBullet : EnemyProjectile
{
    [SerializeField] private float Speed;
    Rigidbody2D rb;
    GameObject target;
    private Vector3 direction;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.Find("MainHero");
        direction = target.transform.position - transform.position;
        Shoot();
        Destroy(gameObject, 6f);
    }
    private void Update()
    {

    }
    void Shoot()
    {
        rb.velocity = new Vector2(direction.x, direction.y).normalized * Speed;
    }
    // Update is called once per frame
    
}
