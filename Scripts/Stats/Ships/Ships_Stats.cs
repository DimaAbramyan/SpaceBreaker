using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
[CreateAssetMenu(fileName = "NewShipData", menuName = "Game/Ship Data")]
public class Ship_Data : ScriptableObject
{
    public int _currentLvl;
    public float _speed;
    public float _mass;
    public float _drag;
    [SerializeField] public float _max_HP;
    [SerializeField] public float _max_SP;
    public int shipId;
    
}

