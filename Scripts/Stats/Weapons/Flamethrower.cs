using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FireProj;

public class Flamethrower : Weapon
{
    public FirstShip ship;
    [SerializeField] private Fire Fire;
    private float _currentFireRate;
    public List<Sprite> RandomFire; 
    [SerializeField] public float[] _rangeByLevel;


    public override void Shoot() 
    {
        
        if (_currentFireRate > 0)
        {
            _currentFireRate -= Time.deltaTime / _currentFireRate;
        }
        else
        {
            Instantiate(Fire, transform.position+new Vector3(0,0.25f,0), Quaternion.Euler(0, 0, 0));
            _currentFireRate = _fireRate;
        }
    }
    private void Awake()
    {
        ship = GetComponentInParent<FirstShip>();

    }
    public Sprite GiveRandomTexture()
    {
        return (RandomFire[Random.Range(0, RandomFire.Count)]);
    }
    void Update()
    {
        
        Shoot();
        Fire.currentLvl = ship.ship_Data._currentLvl;
    }
}
