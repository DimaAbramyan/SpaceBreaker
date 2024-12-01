using System.Collections;
using System.Collections.Generic;
using Minigun_name;
using UnityEngine;
public class Bullet : Projectile
{
    [SerializeField] private float _MaxRange = 7f;
    [SerializeField] protected float _speed;
    private Vector3 _position = new Vector3(0, 1, 0);
    void Start()
    {
        _position = transform.position;
        _position.x = -(Mathf.Tan(Mathf.Deg2Rad * this.gameObject.transform.eulerAngles.z));
        _position.y = Mathf.Sqrt(1 - Mathf.Pow(_position.x, 2));
        Destroy(gameObject, 1/(_MaxRange/_speed));
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        TransformPosition();
    }
    public override void TransformPosition()
    {
        transform.position += _position * this._speed * Time.deltaTime;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        iDamagable receiver = collision.gameObject.GetComponent<iDamagable>();
        if (receiver != null)
        {
            receiver.TakeDamage(_damage);
            Destroy(this.gameObject);
        }
    }
}
