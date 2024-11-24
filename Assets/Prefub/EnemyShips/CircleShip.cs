using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UIElements;

public class CircleShip : Enemy, iDamagable
{
    [SerializeField] private EnemyBullet EnBullet;
    private float Timer;
    
    private void Start()
    {
        Timer = Random.Range(_fireRate/10+1, _fireRate);
    }
    private void Update() 
    {
        Shoot(); 
        MoveForvard();
    }
    protected void Shoot()
    {

        Timer -= Time.deltaTime / Timer;
        if (Timer <= 0)
        {
            Instantiate(EnBullet, transform.position, Quaternion.Euler(0, 0, 0));
            Timer = Random.Range(_fireRate/10+1, _fireRate);
        }
    }
    protected void MoveForvard()
    {
        Vector3 _position = new Vector3(0,-1, 0);
        transform.position += _position * this._speed * Time.deltaTime;
    }
}