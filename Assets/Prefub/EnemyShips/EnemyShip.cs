using System.Collections;
using System.Collections.Generic;
//using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] HealthBar healthBar;
    [SerializeField] protected float _maxHealth;
    protected float _currentHealth;
    [SerializeField] protected float _fireRate;
    [SerializeField] protected float _damage;
    [SerializeField] protected float _speed;
    public void Awake()
    {
        _currentHealth = _maxHealth;
    }
    public void TakeDamage(float t)
    {
        Debug.Log(gameObject);
        _currentHealth -= t;
        Debug.Log(_currentHealth);

        if (healthBar != null)
        {
            healthBar.SetHealth(_currentHealth / (_maxHealth / 100));
        }
        if (_currentHealth <= 0)
        {
            Dying();
        }
    }
    public void Dying()
    {
        Destroy(gameObject);
        Debug.Log("ImDead");
    }
    
}
    