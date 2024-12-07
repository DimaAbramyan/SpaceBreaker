using System.Collections;
using System.Collections.Generic;
//using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerControl : MonoBehaviour
{
    public Rigidbody2D rb;
    public float _controllability = 1;
    public Vector3 _maxspeed = new Vector3 (1f, 1f, 0f);
    public ClassProjectile lasPref;
    Vector3 _currentPosition;
    Vector3 _currentSpeed;
    private void Start()
    {
        InvokeRepeating(nameof(Shoot), 0, ClassProjectile._cooldown);
    }

    private void FixedUpdate()
    {
        _currentPosition = gameObject.transform.position;
        for (int i = 0; i < Input.touchCount; i++)
        {
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(Input.touches[i].position);
            _currentSpeed = (touchPosition - _currentPosition);
            rb.AddForce((_currentSpeed* _controllability));
        }
    }
    void Shoot()
    { 
        ClassProjectile projectile = Instantiate(lasPref, this.transform.position, Quaternion.identity);
      
    }
    

}
