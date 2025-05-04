using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FirstShip : MonoBehaviour, iDamagable
{
    WaveManager waveManager;
    public float _current_SP;
    public float _current_HP;
    public Ship_Data ship_Data;
    [SerializeField] public PlayerHealthBar healthBar;
    [SerializeField] public PlayerHealthBar ShieldBar;
    public void Start()
    {
        waveManager = FindObjectOfType<WaveManager>();
        healthBar = FindObjectOfType<PlayerHealthBar>();
        ShieldBar = FindObjectsOfType<PlayerHealthBar>()[1];
        _current_HP = ship_Data._max_HP;
        _current_SP = ship_Data._max_SP;
        ship_Data._currentLvl = 0;
        ShieldBar.SetHealth(_current_SP / (ship_Data._max_SP / 100));
        healthBar.SetHealth(_current_HP / (ship_Data._max_HP / 100));
    }
    public void Awake()
    {
        //_current_HP = ship_Data._max_HP;
        //_current_SP = ship_Data._max_SP;
        //ShieldBar.SetHealth(_current_SP / (ship_Data._max_SP / 100));
        //healthBar.SetHealth(_current_HP / (ship_Data._max_HP / 100));

    }
    public void Dying()
    {
        waveManager.MainHeroIsDead();
        Destroy(this.gameObject);
    }
    public void TakeDamage(float damage)
    {
        if (_current_SP > 0)
        {
            _current_SP -= damage;
            Debug.Log(_current_SP);
            return;
        }
        _current_HP -= damage;
        Debug.Log(_current_SP);
        if (_current_HP <= 0)
        {
            Dying();
        }
    }
    public void LvlUp()
    {
        if (ship_Data._currentLvl < 4)
        {
            ship_Data._currentLvl++;
        }
    }
}


