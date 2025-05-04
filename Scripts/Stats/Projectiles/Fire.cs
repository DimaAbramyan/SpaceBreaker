using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UIElements;
namespace FireProj
{
    public class Fire : Projectile
    {
        List<float> damagePerLvl = new List<float>() {7.5f, 7.5f, 7.5f, 12.5f, 17.5f};
        [SerializeField] private Image image;
        public int currentLvl; // Способ ублюдский, но работает
        [SerializeField] protected float _speed;
        [SerializeField] private Flamethrower flamethrower;
        private Vector3 _growth = new Vector3(0.001f, 0.001f, 0);
        private SpriteRenderer ImageOfFire;
        Vector3 form;
        Color changeColour;
        private float colorChangeSpeed = 0.5f;
        private FirstShip ship;
        private void Start()
        {
            ImageOfFire = GetComponent<SpriteRenderer>();
            Flamethrower flamethrower = FindAnyObjectByType<Flamethrower>();
            ImageOfFire.sprite = flamethrower.GiveRandomTexture();
            _start_pos = transform.position.y;
            ImageOfFire.color = new Color(1f, 1f, 0.7f);
            changeColour = new Color(0f, 0f, -colorChangeSpeed);
        }
        private void Awake()
        {
        }
        void Update()
        {
            if (Time.timeScale == 0) return;
            form = transform.localScale;
            ChangeColour();
            TransformPosition();
            this._damage = damagePerLvl[currentLvl];
        }
        public override void TransformPosition()
        {
            transform.position += new Vector3(0, 1, 0) * this._speed * Time.deltaTime;
            if (form.x > 0.125)
            {
                _growth = new Vector3(0.0035f, 0.0035f);
            }
            if (form.x > 0.225)
                _growth = new Vector3(0.0075f, 0.0075f);
            transform.localScale += _growth;
            DestroyProjByRange();
        }
        private void ChangeColour()
        {
            
            Color currentColor = ImageOfFire.color;

            if (currentColor.b > 0.0)
            {
                changeColour = new Color(0.4f,-0.7f,-0.5f);
            }
            currentColor = currentColor + changeColour*2 * Time.deltaTime;
            if (currentLvl == 3)
            {
                currentColor += new Color(-0.01f, -0.0125f, -0.0f);
            }
            if (currentLvl == 4)
            {
                currentColor += new Color(-0.05f,-0.005f,0.1f);
            }
          //  Debug.Log(currentLvl);
            ImageOfFire.color = currentColor;
        }
        public override void DestroyProjByRange()
        {

            if (Mathf.Abs(transform.position.y - _start_pos) >=  flamethrower._rangeByLevel[currentLvl])
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
