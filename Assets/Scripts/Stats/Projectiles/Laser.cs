using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace LaserProj
{
    public class Laser : Projectile
    {
        Ship ship;
        private Vector3 scale;
        [SerializeField] private float[] scalePerLvL;
        private float laserLenght = 10;
        private int currentLvl;
        float check;

        private void Start()
        {
            ship = GetComponentInParent<Ship>();
            transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y*3, transform.localScale.z);
            transform.position = transform.position + new Vector3(0, 7, 0);
            scale = transform.localScale;
        }
        private void OnTriggerStay2D(Collider2D collision)
        {
            iDamagable receiver = collision.gameObject.GetComponent<iDamagable>();
            if (receiver != null)
            {
                receiver.TakeDamage(_damage);

            }
        }
        private void Update()
        {
                scale.x = scalePerLvL[ship._currentLvl];
                transform.localScale = scale;
        }
    }
}
