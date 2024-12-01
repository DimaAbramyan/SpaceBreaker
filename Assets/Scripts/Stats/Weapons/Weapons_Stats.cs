using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] protected float _fireRate;
    public static int _levelMax = 5;
    
    public virtual void Shoot()
    {

    }
}
