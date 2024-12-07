using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using cProjectile;
using WeaponInterface;
using System.Threading;
namespace Minigun_name
{
    public class Minigun : MonoBehaviour, IWeapon
    {
        public Pellet pellet;
        public Bullet bulletPref;
        public Transform bulletSpawn;

        private int _levelCurrent = 0;
        public int _levelMax { get; set; } = 5;
        public static float[] rotationsAngles = { 0, 2.5f, 5, 10 };
        public float _fireRate { get; set; } = 0.4f;
        private int shotGun_reload = 100;
        public void shoot()
        {
            for (int i = _levelCurrent; i>=0; i--)
            {
                if (i == 0)
                {
                    Bullet Centrbullet = Instantiate(bulletPref, bulletSpawn.position, Quaternion.Euler(0, 0, 0));
                    _fireRate = 0.4f;
                    shotGun_reload -= 1;
                    break;
                }
                Bullet bulletRight = Instantiate(bulletPref, bulletSpawn.position, Quaternion.Euler(0, 0, rotationsAngles[i]));
                Bullet bulletLeft = Instantiate(bulletPref, bulletSpawn.position, Quaternion.Euler(0, 0, -rotationsAngles[i]));
                shotGun_reload -= 2;
                _fireRate = 0.4f;
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
            if (_fireRate > 0)
            {
                _fireRate -= Time.deltaTime / _fireRate;

            }
            else
            {
                shoot();
            }

        }
    }

}