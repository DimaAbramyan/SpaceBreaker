using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UIElements;

public class SimpleShipWithShield : Enemy
{

    private void Update()
    {
        MoveForvard();
    }
    protected void MoveForvard()
    {
        Vector3 _position = new Vector3(0, -1, 0);
        transform.position += _position * this._speed * Time.deltaTime;
    }
}

