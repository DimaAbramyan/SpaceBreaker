using System.Collections;
using System.Collections.Generic;
using FireProj;
using LaserProj;
using UnityEngine;

public class LaserGun : Weapon
{
    public Laser Laser;
    public Transform LaserSpawn;
    public void shoot()
    {
        Laser.damage = damageperLevel[levelCurrent];
        Instantiate(Laser, LaserSpawn.position, Quaternion.Euler(0, 0, 0));
       
    }
    void Start()
    {
        damageperLevel = new float[5] { 0.3f, 0.4f, 0.5f, 0.7f, 0.9f };
    }

    // Update is called once per frame
    void Update()
    {
        shoot();
    }
}
