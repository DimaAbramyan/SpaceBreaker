using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldRegen : MonoBehaviour
{
    private List<Ship> Ships;
    private void Start()
    {
        Debug.Log("!");
        foreach (Ship ship in transform)
        {
            Ships.Add(ship);
        }
        Debug.Log(Ships.Count);
    }
}
