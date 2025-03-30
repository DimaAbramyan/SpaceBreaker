using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLevel: MonoBehaviour
{
    public static int level = 0;

    public static void LvlUp()
    {
        level++;
    }
    public int GetLvl()
    {
        return level;
    }
}
