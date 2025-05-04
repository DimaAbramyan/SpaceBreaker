using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsCollector:MonoBehaviour
{
    public static float Points;
    public static float MaxPoints;
    public static float Bonuses;
    public static float MaxBonuses;
    private void Start()
    {
        Points = 0;
        MaxPoints = 0;
        Bonuses = 0;
        MaxBonuses = 0;
    }

}
