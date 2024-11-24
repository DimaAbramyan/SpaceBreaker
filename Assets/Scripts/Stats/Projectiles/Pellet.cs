using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Pellet : Projectile
{
    [SerializeField] private float _MaxRange = 8f;
    [SerializeField] protected float _speed;
    private Vector3 _position = new Vector3(0, 1, 0);
    // Start is called before the first frame update
    void Start()
    {
        _position.x = Random.Range(-1f, 1f);
        _position.y = Random.Range(0.5f, 3f);
    }
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

    public override void  TransformPosition()
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
            Debug.Log("Take Damage by Pellet!");
        }
        Destroy(this.gameObject);
    }
}
