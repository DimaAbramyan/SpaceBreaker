using System.Collections;
using System.Collections.Generic;
//using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour, iDamagable 
{
    [SerializeField] BuffLevel Buff;
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
        _currentHealth -= t;

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
        if (this.CompareTag("Enemy"))
        {
            Enemies_Counter.Count++;

        }
        Debug.Log(Enemies_Counter.Count);

        if (Buff != null && Random.Range(1, 8) == 1)
        {
            Instantiate(Buff, transform.position, Quaternion.identity);
        }
    }
    
}
    