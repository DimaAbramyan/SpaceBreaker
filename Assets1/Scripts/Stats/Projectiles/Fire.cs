using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using cProjectile;
using UnityEngine;
using UnityEngine.UIElements;
using cProjectile;
namespace FireProj
{
    public class Fire : MonoBehaviour, IProjectile
    {
        private Vector3 _growth = new Vector3(0.008f, 0.008f, 0);
        public float _damage { get; set; } = 10f;
        public float _speed { get; set; } = 6f;
        public float _maxRange = 0.6f;
        private float _start_pos;
        void Start()
        {
            _start_pos = transform.position.y;
        }

        void Update()
        {
            transform.position += new Vector3(0, 1, 0) * this._speed * Time.deltaTime;
            transform.localScale += _growth;
            if (Mathf.Abs(transform.position.y - _start_pos) >= _maxRange)
            {
                Destroy(gameObject);
            }
        }
    }
}
