using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UIElements;
namespace FireProj
{
    public class Fire : Projectile
    {
        [SerializeField] private Image image;
        public int currentLvl; // Способ ублюдский, но работает
        [SerializeField] protected float _speed;
        [SerializeField] private Flamethrower flamethrower;
        private Vector3 _growth = new Vector3(0.008f, 0.008f, 0);

        private void Start()
        {
            Flamethrower flamethrower = GetComponent<Flamethrower>();
            _start_pos = transform.position.y;
        }
        void Update()
        {
            TransformPosition();
        }
        public override void TransformPosition()
        {
            transform.position += new Vector3(0, 1, 0) * this._speed * Time.deltaTime;
            transform.localScale += _growth;
            DestroyProjByRange();
        }
        public override void DestroyProjByRange()
        {
            if (Mathf.Abs(transform.position.y - _start_pos) >= flamethrower._rangeByLevel[currentLvl])
            {
                Destroy(gameObject);
            }
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
