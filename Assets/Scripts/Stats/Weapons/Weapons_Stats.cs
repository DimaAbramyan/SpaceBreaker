using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] protected float _fireRate;
    [SerializeField] public int _levelCurrent;
    public static int _levelMax = 5;
    public void lvlUp()
    {
        _levelCurrent++;
        if (_levelCurrent >= _levelMax)
        {
            _levelCurrent = _levelMax;
        }
    }
    public virtual void Shoot()
    {

    }
}
