using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FireProj;

public class Flamethrower : Weapon
{
    private Ship ship;
    [SerializeField] private Fire Fire;
    private float _currentFireRate;
   
    [SerializeField] public float[] _rangeByLevel;

    public override void Shoot() 
    {
        
        if (_currentFireRate > 0)
        {
            _currentFireRate -= Time.deltaTime / _currentFireRate;
        }
        else
        {
            Instantiate(Fire, transform.position, Quaternion.Euler(0, 0, 0));
            _currentFireRate = _fireRate;
        }
    }
    private void Awake()
    {
        ship = GetComponentInParent<Ship>();


    }

    void Update()
    {
        Shoot();
        Fire.currentLvl = ship._currentLvl;
    }
}
