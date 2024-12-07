using System.Collections;
using System.Collections.Generic;
using cProjectile;
using Minigun_name;
using UnityEngine;
using WeaponInterface;
public class Bullet : MonoBehaviour, IProjectile
{
    private Vector3 _position = new Vector3(0,1,0);
    public float _damage { get; set; } = 10f;
    public float _speed { get; set; } = 8f;

    void Start()
    {
       _position.x = -(Mathf.Tan(Mathf.Deg2Rad * this.gameObject.transform.eulerAngles.z));
       _position.y = Mathf.Sqrt(1 - Mathf.Pow(_position.x, 2));
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += _position * this._speed * Time.deltaTime;
    }
}
