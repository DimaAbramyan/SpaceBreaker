using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Pellet : Projectile
{
    private Vector3 _position = new Vector3(0, 1, 0);
    // Start is called before the first frame update
    void Start()
    {
        damage = 2f;
        speed = 2f;
        maxRange = 15f;
        _position.x = Random.Range(-1f, 1f);
        _position.y = Random.Range(0.5f, 3f);
    }
    void Update()
    {
        transform.position += _position * this.speed * Time.deltaTime;
    }
}
