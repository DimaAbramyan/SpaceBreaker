using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : EnemyProjectile
{
    [SerializeField] private float _MaxRange;
    [SerializeField] protected float _speed;
    private Vector3 _position = new Vector3(0, -1, 0);
    // public CircleShip():base(1000,20,20) {}
    void Start()
    {
       // _position = transform.position;
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
        iDamagable receiver = collision.gameObject.GetComponentInChildren<iDamagable>();
        Debug.Log(receiver);
        if (receiver != null)
        {
            receiver.TakeDamage(_damage);
            Destroy(gameObject);
        }
        

    }
}
