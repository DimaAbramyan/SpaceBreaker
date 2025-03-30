using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
//using Unity.VisualScripting;
using UnityEngine;
using TMPro;
using static UnityEngine.GraphicsBuffer;

public class Enemy : MonoBehaviour, iDamagable 
{
    [SerializeField] TextMeshPro DamageShowing;
    [SerializeField] public Buff Buff;
    [SerializeField] HealthBar healthBar;
    [SerializeField] protected float _maxHealth;
    protected float _currentHealth;
    [SerializeField] protected float _fireRate;
    [SerializeField] protected float _damage;
    [SerializeField] protected float _speed;
    DamageNumbPool damageToShow;
    public void Awake()
    {
        damageToShow = FindObjectOfType<DamageNumbPool>();
        _currentHealth = _maxHealth;
    }
    public void TakeDamage(float t)
    {
        GameObject ShowIcon = null;
        _currentHealth -= t;
        if (t > 3)
        {
            ShowIcon = damageToShow.GetDamageNumber(t);
        }
        if (healthBar != null)
        {
            healthBar.SetHealth(_currentHealth / (_maxHealth / 100));
        }
        if (_currentHealth <= 0)
        {
            Dying();
        }
        if (ShowIcon)
        {
            ShowIcon.GetComponent<RectTransform>().position = Camera.main.WorldToScreenPoint(this.transform.position);
        }
    }
    public void Dying()
    {
       
        Destroy(gameObject);
        if (GetComponent<IHaveBuff>() != null && Buff != null)
        {
            Instantiate(Buff, transform.position, Quaternion.identity);
        }
    }
    
}
    