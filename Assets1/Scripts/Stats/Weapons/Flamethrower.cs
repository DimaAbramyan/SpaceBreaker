using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WeaponInterface;
using FireProj;

public class NewBehaviourScript : MonoBehaviour, IWeapon
{
    public Fire Fire;
    public Transform FlameSpawn;
    private int _levelCurrent = 0;
    private float[] _rangeByLevel = { 2.5f,3f, 4f, 5f, 5f };
    private float[] _damageByLevel = { 10, 15, 20, 30, 50 };
    public int _levelMax { get; set; } = 5;
    public float _fireRate { get; set; } = 0.5f;
    public void shoot() 
    {
        Fire._damage = _damageByLevel[_levelCurrent];
        Fire._maxRange = _rangeByLevel[_levelCurrent];
        Instantiate(Fire, FlameSpawn.position, Quaternion.Euler(0, 0, 0));
        _fireRate = 0.5f;
    }

    void Update()
    {
        if (_fireRate > 0)
        {
            _fireRate -= Time.deltaTime / _fireRate;
        }
        else
        {
            shoot();
        }
    }
}
