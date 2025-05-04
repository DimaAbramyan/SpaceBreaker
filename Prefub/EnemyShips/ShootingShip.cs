using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UIElements;

public class ShootingShip : Enemy
{
    [SerializeField] private EnemyBullet EnBullet;
    [SerializeField] Animator animator;
    private float Timer;
    
    private void Start()
    {
        Timer = Random.Range(_fireRate/10+1, _fireRate);
    }
    private void Update() 
    {
        if (EnBullet)
        Shoot(); 
        MoveForvard();
    }
    protected void Shoot()
    {
        Timer -= Time.deltaTime / Timer;
        if (Timer <= 0)
        {
            if (!animator.GetBool("Shooting"))
                animator.SetBool("Shooting", true);
            Timer = Random.Range(_fireRate / 10 + 1, _fireRate);
        }
    }
    protected void MoveForvard()
    {
        //Vector3 _position = new Vector3(0,-1, 0);
        //transform.position += _position * this._speed * Time.deltaTime;
    }
    private void StartAnimation()
    {
        Vector3 direction = transform.up.normalized;
        EnemyBullet bull = Instantiate(EnBullet, transform.position + new Vector3(0, -0.25f), Quaternion.identity);
        bull._position = direction;

        // Поворачиваем снаряд в сторону направления полёта
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        bull.transform.rotation = Quaternion.Euler(0, 0, angle+90);

        animator.SetBool("Shooting", false);
    }
}
