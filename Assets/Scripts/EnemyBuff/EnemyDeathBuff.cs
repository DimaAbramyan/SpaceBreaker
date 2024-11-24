using System.Collections;
using System.Collections.Generic;
//using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class ItemDrop : MonoBehaviour
{
    [SerializeField]
    private int _Buff; // drop for buff
    private Transform Epos; // enemy position

private void Start()
{
    Epos = GetComponent<Transform>();
}

private void Update()
{ 
if (EnemyShip._CurrentHealth <= 0 ) {
    Instantiate(_Buff, Epos.position, Quaternion.identity);
}
}
}