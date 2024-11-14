using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace LaserProj
{
    public class Laser : Projectile
    {
        private Vector3 _position;
        private LaserGun laserGun;
        private float laserLenght = 10;
        void Start()
        {
            damage = 10f;
            speed = 8f;
            maxRange = 15f;
            laserGun = GameObject.Find("LaserGun").GetComponent<LaserGun>();
            transform.position = laserGun.transform.position;
            transform.localPosition += new Vector3(0, 5.5f);
            Vector3 lTemp = transform.localScale;
            lTemp.x = laserGun.damageperLevel[laserGun.levelCurrent];
            transform.localScale = lTemp;
        }

        void Update()
        {
            Destroy(this.gameObject);

        }
    }
}
