using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using System.Threading;
namespace Minigun_name
{
    public class Minigun : Weapon
    {
        public Pellet pellet;
        public Bullet bulletPref;
        public Transform bulletSpawn;
        public static float[] rotationsAnglesperLvl = { 0, 2.5f, 5, 10, 15 };
        private int shotGun_reload = 100;
        public void shoot()
        {
            for (int i = levelCurrent; i>=0; i--)
            {
                if (i == 0)
                {
                    Bullet Centrbullet = Instantiate(bulletPref, bulletSpawn.position, Quaternion.Euler(0, 0, 0));
                    fireRate = 0.4f;
                    shotGun_reload -= 1;
                    break;
                }
                Bullet bulletRight = Instantiate(bulletPref, bulletSpawn.position, Quaternion.Euler(0, 0, rotationsAnglesperLvl[i]));
                Bullet bulletLeft = Instantiate(bulletPref, bulletSpawn.position, Quaternion.Euler(0, 0, -rotationsAnglesperLvl[i]));
                shotGun_reload -= 2;
                fireRate = 0.4f;
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
        private void Start()
        {
            fireRate = 0.4f;
            damageperLevel = new float[5] { 4, 4, 4, 4, 4 };
        }
        private void Update()
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

}