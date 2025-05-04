using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace LaserProj
{
    public class Laser : Projectile
    {
        FirstShip ship;
        private Vector3 scale;
        [SerializeField] private float[] scalePerLvL;
        private float laserLenght = 10;
        private int currentLvl;
        float check;
        [SerializeField] private List<float> damagePerLvl;
        public void Start()
        {
            ship = GetComponentInParent<FirstShip>();
            transform.localScale = new Vector3(transform.localScale.x/5, transform.localScale.y*3, transform.localScale.z);
            int Id = ship.ship_Data.shipId;
            
            scale = transform.localScale;
            transform.localScale = new Vector3(1,1,1);
            LaserGun weapon = GetComponentInParent<LaserGun>();
            transform.localPosition = new Vector3(transform.localPosition.x, 105.25f, transform.localPosition.z);
            //transform.position = weapon.GetComponent<Transform>().localPosition;
            transform.localScale = scale;
        }
        private void OnTriggerStay2D(Collider2D collision)
        {
            iDamagable receiver = collision.gameObject.GetComponent<iDamagable>();
            if (receiver != null)
            {
                receiver.TakeDamage(_damage);

            }
        }
        public void Update()
        {

            _damage = damagePerLvl[ship.ship_Data.shipId];
            scale.x = scalePerLvL[ship.ship_Data._currentLvl]; //Не спрашивайте
            
            transform.localScale = scale;
            
        }
    }
}
