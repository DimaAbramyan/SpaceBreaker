using System.Collections;
using System.Collections.Generic;
//using Unity.VisualScripting;
using UnityEngine;

public class ClassProjectile : MonoBehaviour
{
    public Vector3 _position;
    public System.Action destoyed;
    // public GameObject _projectile;
    public float _projectileSpeed = 0.0f;
    public static float _cooldown = 0.1f;

    // Update is called once per frame
    void Update()
    {
        Shoot();
    }
    public void Shoot()
    {
        this.transform.position += this._position * this._projectileSpeed * Time.deltaTime;
        Destroy(gameObject, 1);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        this.destoyed.Invoke();
        Destroy(this.gameObject);
    }
}
