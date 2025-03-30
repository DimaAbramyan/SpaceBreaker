using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using System.Threading;
namespace Minigun_name
{
    public class Minigun : Weapon
    {
        private FirstShip ship ;
        public Pellet pellet;
        public Bullet bulletPref;
        public Transform bulletSpawn;
        private float _currentFireRate;
        public static float[] rotationsAnglesPerLvL = { 0, 2.5f, 5, 10, 15 };
        private int shotGun_reload = 100;
        public override void Shoot()
        {
            for (int i = ship.ship_Data._currentLvl; i>=0; i--)
            {
                if (i == 0)
                {
                    Instantiate(bulletPref, bulletSpawn.position, Quaternion.Euler(0, 0, 0));
                    _currentFireRate = _fireRate;
                    shotGun_reload -= 1;
                    continue;
                }
                Instantiate(bulletPref, bulletSpawn.position, Quaternion.Euler(0, 0, rotationsAnglesPerLvL[i]));
                Instantiate(bulletPref, bulletSpawn.position, Quaternion.Euler(0, 0, -rotationsAnglesPerLvL[i]));
                shotGun_reload -= 2;
                _currentFireRate = _fireRate;
            }
            if (shotGun_reload <= 0)
            {
                for (int i = 0; i < 25; i++)
                {
                    Instantiate(pellet, bulletSpawn.position, Quaternion.Euler(0, 0, 0));
                }
                shotGun_reload = 100;
            }
        }
        private void Update()
        {
            if (_currentFireRate > 0)
            {
                _currentFireRate -= Time.deltaTime / _currentFireRate;
            }
            else
            {
                Shoot();
            }


        }
        private void Start()
        {
            _currentFireRate = _fireRate;
            ship= GetComponentInParent<FirstShip>();
        }
    }

}