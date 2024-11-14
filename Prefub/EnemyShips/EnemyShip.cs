using System.Collections;
using System.Collections.Generic;
//using Unity.VisualScripting;
using UnityEngine;

class Enemy : Monobehavior
{
    public int _MaxHealth;
    public int _CurrentHealth;
    public int _MoveSpeed;
    public int _Damage;
}

publick Enemy(int MaxHealth, int CurrentHealth, int MoveSpeed, int Damage)
{
    this._MaxHealth = 100;
    this._CurrentHealth = 100;
    this._MoveSpeed = 20
    this._Damage = 10;
}

static void Main()
{
    Enemy EnemyShip = new Enemy(100, 100, 20, 10)
}
    