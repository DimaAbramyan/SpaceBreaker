using System.Collections;
using System.Collections.Generic;
using cProjectile;
using UnityEngine;

namespace WeaponInterface
{
    public interface IWeapon
    {
        float _fireRate { get; set; }
        int _levelMax { get; set; }
        void shoot();
    }
    public class Weapons_Stats : MonoBehaviour
    {

    }
}
