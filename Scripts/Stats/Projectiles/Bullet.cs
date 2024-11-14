using System.Collections;
using System.Collections.Generic;
using Minigun_name;
using UnityEngine;
public class Bullet : Projectile
{
    private Vector3 _position = new Vector3(0,1,0);

    void Start()
    {
        damage = 10f;
        speed = 8f;
        maxRange = 15f;
        start_pos = transform.position.y;
        _position.x = -(Mathf.Tan(Mathf.Deg2Rad * this.gameObject.transform.eulerAngles.z));
       _position.y = Mathf.Sqrt(1 - Mathf.Pow(_position.x, 2));
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += _position * this.speed * Time.deltaTime;
    }
}
