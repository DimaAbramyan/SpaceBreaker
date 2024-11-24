using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FireProj;

public class Flamethrower : Weapon
{
    public Fire Fire;
    private float _currentFireRate;

    [SerializeField] public float[] _rangeByLevel;

    public override void Shoot() 
    {
        Fire.currentLvl = _levelCurrent;
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
    private void Start()
    {
        _currentFireRate = _fireRate;
    }

    void Update()
    {
        Shoot();

    }
}
