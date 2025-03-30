using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldRegen : MonoBehaviour
{
    private FirstShip[] ships;
    private void Start()
    {
        ships = GameObject.Find("MainHero").GetComponentsInChildren<FirstShip>();
        
        StartCoroutine(shieldRegen());
    }
    private void Update()
    {
       
    }
    IEnumerator shieldRegen()
    {
        while (true)
        {
            yield return null;
        }
    }
}
