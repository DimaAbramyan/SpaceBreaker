using System.Collections;
using System.Collections.Generic;
using ShipInterface;
using UnityEngine;

public class Capsulehip : MonoBehaviour, IShip
{
    public float _speed { get; set; } = 500;
    public float _mass { get; set; } = 5;
    public float _drag { get; set; } = 30;
    public float _max_HP { get; set; } = 150;
    public float _current_HP { get; set; } = 150;
    public void shoot()
    {

    }
    public void update()
    {

    }
}
