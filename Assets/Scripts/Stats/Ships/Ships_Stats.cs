using System.Collections;
using System.Collections.Generic;
using UnityEngine;
    public class Ship : MonoBehaviour 
{
    public float _speed;
    public float _mass;
    public float _drag;
    [SerializeField] protected float _max_HP;
    protected float _current_HP;
    [SerializeField] protected float _max_SP;
    protected float _current_SP;
    [SerializeField] private PlayerHealthBar healthBar;
    [SerializeField] private PlayerHealthBar ShieldBar;
    public void Start()
    {
        _current_HP = _max_HP;
        _current_SP = _max_SP;
    }
    public void Dying()
    {
        Destroy(gameObject);
    }
    public void TakeDamage(float damage)
    {
        if (_current_SP > 0)
        {
            _current_SP -= damage;
            Debug.Log(_current_SP);
            ShieldBar.SetHealth(_current_SP / (_max_SP / 100));
            return;
        }
        _current_HP -= damage;
        healthBar.SetHealth(_current_HP / (_max_HP / 100));
        Debug.Log(_current_HP);
        if (_current_HP <= 0)
        {
            Dying();
        }
    }
    /// <summary>
    /// Изменяет физическое значение массы, трение, а также скорость текущего корабля
    /// </summary>
    /// <param name="currShip"></param>
   
    
}

