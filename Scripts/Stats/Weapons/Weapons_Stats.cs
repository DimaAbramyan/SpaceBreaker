using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [HideInInspector] public float fireRate;
    private int levelMax = 4;
    public int levelCurrent = 0;
    [HideInInspector] public float[] damageperLevel = new float[4];
    void lvlUp()
    {
        levelCurrent++;
        if (levelCurrent >= levelMax)
        {
            levelCurrent = levelMax;
        }
    }
}
