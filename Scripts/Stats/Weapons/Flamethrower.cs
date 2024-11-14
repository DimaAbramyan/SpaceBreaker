using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FireProj;

public class Flamethrower : Weapon
{
    public Fire Fire;
    public Transform FlameSpawn;

    private float[] rangeByLevel = new float[5] {2,4,6,8,10};
    public void shoot() 
    {
       // Fire.damage = damageperLevel[levelCurrent];
        Fire.maxRange = rangeByLevel[levelCurrent];
        Instantiate(Fire, FlameSpawn.position, Quaternion.Euler(0, 0, 0));
        fireRate = 0.5f;
    }
    private void Start()
    {
    fireRate = 0.5f;
    damageperLevel = new float[5] {50,60,75,90,100 };
}

    void Update()
    {
        if (fireRate > 0)
        {
            fireRate -= Time.deltaTime / fireRate;
        }
        else
        {
            shoot();
        }
    }
}
