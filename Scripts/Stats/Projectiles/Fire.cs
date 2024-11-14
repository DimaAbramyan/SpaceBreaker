using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UIElements;
namespace FireProj
{
    public class Fire : Projectile
    {
        private Vector3 _growth = new Vector3(0.008f, 0.008f, 0);
        void Start()
        {
            damage = 50f;
            speed = 6f; 
            start_pos = transform.position.y;
        }

        void Update()
        {
            transform.position += new Vector3(0, 1, 0) * this.speed * Time.deltaTime;
            transform.localScale += _growth;
            if (Mathf.Abs(transform.position.y - start_pos) >= maxRange)
            {
                Destroy(gameObject);
            }
        }
    }
}
