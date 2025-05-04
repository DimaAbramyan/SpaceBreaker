using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
//using Unity.VisualScripting;
using UnityEngine;
using TMPro;
using static UnityEngine.GraphicsBuffer;

public class Enemy : MonoBehaviour, iDamagable 
{
    public bool isDead = false;
    [SerializeField] TextMeshPro DamageShowing;
    [SerializeField] public Buff Buff;
    [SerializeField] HealthBar healthBar;
    [SerializeField] protected float _maxHealth;
    public float _currentHealth;
    [SerializeField] protected float _fireRate;
    [SerializeField] protected float _damage;
    [SerializeField] protected float _speed;
    DamageNumbPool damageToShow;
    Parameters par;
    private SpriteRenderer spriteRenderer;
    public void Awake()
    {
        
        spriteRenderer = GetComponent<SpriteRenderer>();
        
        if (Buff != null)
        {
            PointsCollector.MaxPoints += _maxHealth;
        }
        damageToShow = FindObjectOfType<DamageNumbPool>();
        _currentHealth = _maxHealth;
        par = FindAnyObjectByType<Parameters>();
    }
    public void TakeDamage(float t)
    {
        if (!spriteRenderer.isVisible)
            return;
        GameObject ShowIcon = null;
        _currentHealth -= t;
        if ((t > 3) && (par.IsParticlesOn))
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
        if (isDead) return;
        if (GetComponent<IHaveBuff>() != null && Buff != null)
        {
            Instantiate(Buff, transform.position, Quaternion.identity);
            
        }
        if (this.Buff != null) 
        PointsCollector.Points += _maxHealth;
        isDead = true;
        Destroy(gameObject);
    }
    
}
    