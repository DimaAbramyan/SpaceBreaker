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
    public virtual void OnCollisionEnter2D() { }
    private void Start()
    {
        
    }
}