using System.Collections;
using System.Collections.Generic;
using FireProj;
using LaserProj;
using UnityEngine;

public class LaserGun : Weapon
{
    public Laser Laser;
    public Transform LaserSpawn;
    [SerializeField] public float[] _ScalePerLvL;
    public void shoot()
    {
       // Laser._damage = damageperLevel[_levelCurrent];
        Instantiate(Laser, LaserSpawn.position, Quaternion.Euler(0, 0, 0));
       
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        shoot();
    }
}
