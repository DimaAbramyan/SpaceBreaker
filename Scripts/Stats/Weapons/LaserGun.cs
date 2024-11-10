using System.Collections;
using System.Collections.Generic;
using FireProj;
using LaserProj;
using UnityEngine;
using WeaponInterface;

public class LaserGun : MonoBehaviour, IWeapon
{
    public Laser Laser;
    public Transform LaserSpawn;
    public int _levelMax { get; set; } = 5;
    public float _fireRate { get; set; } = 0.0f;
    private float[] _damageByLevel = { 10, 15, 20, 30, 50 };
    public int _levelCurrent = 0;
    public void shoot()
    {
        Laser._damage = _damageByLevel[_levelCurrent];
        Instantiate(Laser, LaserSpawn.position, Quaternion.Euler(0, 0, 0));
       
    }

    // Update is called once per frame
    void Update()
    {
        shoot();
    }
}
