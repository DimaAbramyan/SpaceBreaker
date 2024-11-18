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
            laserGun = GameObject.Find("LaserGun").GetComponent<LaserGun>();
            transform.position = laserGun.transform.position;
            transform.localPosition += new Vector3(0, 5.5f);
            Vector3 lTemp = transform.localScale;
            lTemp.x = laserGun._ScalePerLvL[laserGun._levelCurrent];
            transform.localScale = lTemp;
        }

        void Update()
        {
            Destroy(this.gameObject);
        }
        private void OnTriggerEnter2D(Collider2D collision)
        {

            iDamagable receiver = collision.gameObject.GetComponent<iDamagable>();

            if (receiver != null)
            {
                receiver.TakeDamage(_damage);

            }
        }
    }
}
