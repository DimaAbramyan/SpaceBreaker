using System.Collections;
using System.Collections.Generic;
using Minigun_name;
using UnityEngine;
public class Bullet : Projectile
{
    [SerializeField] private float _MaxRange = 7f;
    [SerializeField] protected float _speed;
    private Vector3 _position = new Vector3(0, 1, 0);
    // public CircleShip():base(1000,20,20) {}
    void Start()
    {
        _position = transform.position;
        _position.x = -(Mathf.Tan(Mathf.Deg2Rad * this.gameObject.transform.eulerAngles.z));
        _position.y = Mathf.Sqrt(1 - Mathf.Pow(_position.x, 2));
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        TransformPosition();
       
    }
    public override void DestroyProjByRange()
    {
        if (Mathf.Abs(transform.position.y - _start_pos) >= _MaxRange)
        {
            Destroy(gameObject);
        }
    }
    public override void TransformPosition()
    {
        transform.position += _position * this._speed * Time.deltaTime;

        DestroyProjByRange();
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
