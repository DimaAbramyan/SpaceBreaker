using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructor : Enemy
{
    // Start is called before the first frame update
    private void Update()
    {
        MoveForvard();
    }
    protected void MoveForvard()
    {
        //Vector3 _position = new Vector3(0, -1, 0);
        //transform.position += _position * this._speed * Time.deltaTime;
    }
}
