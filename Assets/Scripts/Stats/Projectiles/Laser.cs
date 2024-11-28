using System.Collections;
using System.Collections.Generic;
using cProjectile;
using UnityEngine;
namespace LaserProj
{
    public class Laser : MonoBehaviour, IProjectile
    {
        private Vector3 _position;
        private LaserGun laserGun;
        public float _damage { get; set; } = 50f;
        public float _speed { get; set; } = 0f;
        private float laserLenght = 10;
        void Start()
        {
            laserGun = GameObject.Find("LaserGun").GetComponent<LaserGun>();
            this.transform.position = laserGun.transform.position;
            
            this.transform.localPosition += new Vector3(0, 7.5f);
            //Debug.Log(laserGun.transform.position);
        }

        void Update()
        {
            Destroy(this.gameObject);

        }
    }
}
