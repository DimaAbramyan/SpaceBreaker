using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ShipInterface;
public class Tetraid_Ship : MonoBehaviour, IShip
{
    public float _speed { get; set; } = 1000;
    public float _mass { get; set; } = 1;
    public float _drag { get; set; } = 20;
    public float _max_HP { get; set; } = 100;
    public float _current_HP { get; set; } = 100;
    public void shoot()
    {

    }
    public void update()
    {

    }
}
