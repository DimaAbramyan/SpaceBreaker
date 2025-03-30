using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UIElements;

public class MotherShip : Enemy
{
    [SerializeField] private ShootMiniShips handler;
    //[SerializeField] private EnemyBullet EnBullet;
    public float Timer;

    private void Start()
    {
        Timer = _fireRate;
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
            handler.LaunchShips();
            
        }
    }
    protected void MoveForvard()
    {
        Vector3 _position = new Vector3(0, -1, 0);
        transform.position += _position * this._speed * Time.deltaTime;
    }
    
}
