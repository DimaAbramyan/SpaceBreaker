using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public abstract class EnemyProjectile: MonoBehaviour
{
    protected float _start_pos;
    protected Vector3 _current_pos;
    [SerializeField] protected float _damage;

    public virtual void TransformPosition(){}
    public virtual void DestroyProjByRange() { }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        FirstShip receiver = collision.gameObject.GetComponentInChildren<FirstShip>();
        Parameters param = FindAnyObjectByType<Parameters>();
        if (receiver != null && !param.IsGodModeOn)
        {
            receiver.TakeDamage(_damage);
            
        }
        Destroy(gameObject);
    }
    private void Start()
    {
        
    }
}